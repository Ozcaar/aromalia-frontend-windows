using Guna.UI2.WinForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aromalia
{
    public partial class FormInventario : Form
    {
        public class Categoria
        {
            public long id { get; set; }
            public string nombre { get; set; }

        }

        public class Producto
        {
            public long id { get; set; }
            public string sku { get; set; }
            public string nombre { get; set; }
            public long stock { get; set; }
            public float precio { get; set; }
            public string descripcion { get; set; }
            public Categoria categoria { get; set; }
            public string alto { get; set; }
            public string ancho { get; set; }
            public string peso { get; set; }
            public string imagen { get; set; }
        }

        private List<Producto> productos;
        private string apiURL;
        private Form activeForm = null;

        public FormInventario()
        {
            InitializeComponent();
            productos = new List<Producto>();
            apiURL = "http://localhost:8080";
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            string endpoint = "http://localhost:8080/productos";

            try
            {
                using (WebClient wc = new WebClient())
                {
                    // Especificar la codificación UTF-8
                    wc.Encoding = Encoding.UTF8;

                    //Descargar los datos de la api en formato JSON
                    string json = wc.DownloadString(apiURL + "/productos");

                    //Convertir el JSON en una lista de objetos
                    var datos = JsonConvert.DeserializeObject<List<Producto>>(json);

                    List<Producto> listaProductos = JsonConvert.DeserializeObject<List<Producto>>(json);

                    productos = listaProductos;


                    // Llenar el DataGridView con los datos
                    //inventarioTabla_dgv.DataSource = datos;
                    inventarioTabla_dgv.DataSource = productos;

                    // Agrega el evento CellFormatting al DataGridView
                    inventarioTabla_dgv.CellFormatting += (sender, e) =>
                    {
                        if (e.ColumnIndex == inventarioTabla_dgv.Columns["Categoria"].Index && e.Value != null)
                        {
                            // Verifica que el valor no sea nulo y que sea de tipo Categoria
                            if (e.Value is Categoria categoria)
                            {
                                // Asigna el valor de la propiedad Nombre_categoria al valor de la celda
                                e.Value = categoria.nombre;
                            }
                        }
                    };

                    //inventarioTabla_dgv.Columns["Nombre"].HeaderText = "Nombre del Producto";
                }
            } catch (Exception ex)
            {
                //Mostrar mensaje de error
                MessageBox.Show("Error al descargar los datos: " + ex.Message);
            }
        }

        private void filtrarSinStock()
        {
            var productoSinStock = productos.Where(item => item.stock < 1).ToList();
            //inventarioTabla_dgv.DataSource = productoSinStock;
            filtrarBusqueda(productoSinStock);
        }
        private void filtrarBusqueda(List<Producto> lista)
        {

            var productoBuscado = lista.Where(item => item.nombre.ToLower().Contains(tboxBusqueda.Text.ToLower())).ToList();
            inventarioTabla_dgv.DataSource = productoBuscado;
        }

        private bool validarCampos()
        {
            var nombre = tbox_nombre.Text;
            var stock = tbox_stock.Value;
            var precio = tbox_precio.Value;
            var descripcion = tbox_descripcion.Text;

            if (nombre == null || nombre.Trim() == "")
            {
                MessageBox.Show("El nombre no puede quedar vacío");
                return false;
            }

            if (descripcion == null || descripcion.Trim() == "")
            {
                MessageBox.Show("La descripción no puede quedar vacía");
                return false;
            }
            return true;
        }

        private void vaciarFormulario()
        {
            tbox_nombre.ResetText();
            tbox_stock.Value = 0;
            tbox_precio.Value = 0.00M;
            tbox_descripcion.ResetText();
        }

        private void abrirEditarProducto(DataGridViewRow filaSeleccionada)
        {
            // Oculta el formulario principal
            this.Hide();

            // Crea una instancia del formulario de edición de productos
            EditarProducto editarProducto = new EditarProducto(filaSeleccionada);

            // Muestra el formulario de edición de productos como un diálogo modal
            editarProducto.ShowDialog(this);

            // Muestra nuevamente el formulario principal después de que se cierra el diálogo de edición de productos
            CargarProductos();
            this.Show();
        }

        // EVENTOS

        private void btn_todo_Click(object sender, EventArgs e)
        {
            //inventarioTabla_dgv.DataSource = productos;
            filtrarBusqueda(productos);
        }

        private void btn_sin_stock_Click(object sender, EventArgs e)
        {
            filtrarSinStock();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (validarCampos() == false) 
            {
                return;
            }

            string nombre = tbox_nombre.Text;
            long stock = long.Parse(tbox_stock.Text);
            float precio = float.Parse(tbox_precio.Text);
            string descripcion = tbox_descripcion.Text;

            var producto = new Producto
            {
                nombre = nombre,
                stock = stock,
                precio = precio,
                descripcion = descripcion,
            };

            try
            {

                string productoJSON = JsonConvert.SerializeObject(producto);

                using (WebClient wc = new WebClient())
                {
                    wc.Encoding = Encoding.UTF8;

                    // Configurar el tipo de contenido de la solicitud
                    wc.Headers[HttpRequestHeader.ContentType] = "application/json";

                    // Enviar la solicitud POST y obtener la respuesta
                    string response = wc.UploadString(apiURL + "/productos", productoJSON);

                    CargarProductos();
                    MessageBox.Show("¡Se ha agregado un nuevo producto!");
                    vaciarFormulario();
                }
            }
            catch (WebException ex)
            {
                // Manejar errores de red o de la API
                MessageBox.Show("Error en la solicitud: " + ex.Message);
            }
        }

        private void tbox_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un dígito numérico o una tecla de control (como retroceso o suprimir)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un dígito numérico, se cancela la entrada de la tecla presionada
                e.Handled = true;
            }
        }

        private void tbox_stock_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

            if (inventarioTabla_dgv.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int rowIndex = inventarioTabla_dgv.SelectedRows[0].Index;

                // Accede a los valores de las celdas de la fila seleccionada usando el nombre de la columna
                string sku = inventarioTabla_dgv.Rows[rowIndex].Cells["sku"].Value.ToString();

                DataGridViewRow filaSeleccionada = inventarioTabla_dgv.Rows[rowIndex];

                Console.WriteLine(filaSeleccionada.Cells);

                abrirEditarProducto(filaSeleccionada);

            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro que deseas eliminar el elemento seleccionado?", "Eliminar", MessageBoxButtons.YesNo);


            if (dialogResult == DialogResult.No)
            {
                return;
            }

            if (inventarioTabla_dgv.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int rowIndex = inventarioTabla_dgv.SelectedRows[0].Index;

                // Accede a los valores de las celdas de la fila seleccionada usando el nombre de la columna
                string sku = inventarioTabla_dgv.Rows[rowIndex].Cells["sku"].Value.ToString();

                // Cliente WebClient
                using (WebClient wc = new WebClient())
                {
                    try
                    {
                        // Hacer la petición DELETE y capturar la respuesta
                        byte[] responseBytes = wc.UploadData(apiURL + "/productos/sku/" + sku, "DELETE", new byte[] { });
                        
                        // Respuesta satisfactoria
                        CargarProductos();
                        MessageBox.Show("¡Se ha eliminado el producto!");
                    }
                    catch (WebException ex)
                    {
                        // Capturar errores de red
                        MessageBox.Show("Error al intentar eliminar el recurso: " + ex.Message);
                    }

                }
            }
        }

        private void inventarioTabla_dgv_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            // Verifica si hay una fila seleccionada
            if (inventarioTabla_dgv.SelectedRows.Count > 0)
            {
                // Obtiene el índice de la fila seleccionada
                int rowIndex = inventarioTabla_dgv.SelectedRows[0].Index;

                // Accede a los valores de las celdas de la fila seleccionada usando el índice de columna o el nombre de la columna
                string sku = inventarioTabla_dgv.Rows[rowIndex].Cells["sku"].Value.ToString();


                formSKU_txt.Text = "SKU: #" + sku;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (btn_sin_stock.Enabled)
            {
                filtrarSinStock();
            } else
            {
                filtrarBusqueda(productos);
            }
        }
    }
}
