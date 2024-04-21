using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Aromalia.FormInventario;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aromalia
{
    public partial class EditarProducto : Form
    {

        //public class Categoria
        //{
        //    public long id { get; set; }
        //    public string nombre { get; set; }
        //}

        private DataGridViewRow filaSeleccionada;
        private string apiURL;

        //Categoria claseCategoria = new Categoria();
        List<Categoria> listaCategorias;

        public EditarProducto(DataGridViewRow filaSeleccionada)
        {
            InitializeComponent();
            this.apiURL = "http://localhost:8080";

            this.filaSeleccionada = filaSeleccionada;
            rellenarFormulario();

            // No es necesario establecer la propiedad FormBorderStyle en None si no deseas bordes redondeados
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
        }

        private void rellenarFormulario()
        {
            txtSKU.Text = this.filaSeleccionada.Cells["sku"].Value != null ? "SKU: #" + this.filaSeleccionada.Cells["sku"].Value.ToString() : "";
            tboxNombre.Text = this.filaSeleccionada.Cells["nombre"].Value != null ? this.filaSeleccionada.Cells["nombre"].Value.ToString() : "";
            tboxStock.Value = this.filaSeleccionada.Cells["stock"].Value != null ? decimal.Parse(this.filaSeleccionada.Cells["stock"].Value.ToString()) : 0;
            tboxPrecio.Value = this.filaSeleccionada.Cells["precio"].Value != null ? decimal.Parse(this.filaSeleccionada.Cells["precio"].Value.ToString()) : 0;
            tboxDescripcion.Text = this.filaSeleccionada.Cells["descripcion"].Value != null ? this.filaSeleccionada.Cells["descripcion"].Value.ToString() : "";
            tboxAlto.Text = this.filaSeleccionada.Cells["alto"].Value != null ? this.filaSeleccionada.Cells["alto"].Value.ToString() : "";
            tboxAncho.Text = this.filaSeleccionada.Cells["ancho"].Value != null ? this.filaSeleccionada.Cells["ancho"].Value.ToString() : "";
            tboxPeso.Text = this.filaSeleccionada.Cells["peso"].Value != null ? this.filaSeleccionada.Cells["peso"].Value.ToString() : "";

            cargarCategorías();
        }


        // Bordes redondeados
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void EditarProducto_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            // Crear un cuadro de diálogo para abrir archivos
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Filtro para mostrar solo archivos de imagen
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif";

            // Mostrar el cuadro de diálogo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Obtener la ruta del archivo seleccionado
                    string rutaImagen = openFileDialog.FileName;

                    string nombreArchivo = Path.GetFileName(rutaImagen);


                    btnSeleccionarImagen.Text = nombreArchivo;

                    // Cargar la imagen en el PictureBox
                    //pictureBox1.Image = Image.FromFile(rutaImagen);

                    // Ajustar el tamaño del PictureBox para que se ajuste a la imagen
                    //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al cargar la imagen: " + ex.Message);
                }
            }
        }

        private void cargarCategorías()
        {
            using (WebClient wc = new WebClient())
            {
                // Especificar la codificación UTF-8
                wc.Encoding = Encoding.UTF8;

                //Descargar los datos de la api en formato JSON
                string json = wc.DownloadString(apiURL + "/categorias");

                //Convertir el JSON en una lista de objetos
                this.listaCategorias = JsonConvert.DeserializeObject<List<Categoria>>(json);


                // Rellenar el ComboBox
                foreach (var categoria in this.listaCategorias)
                {
                    cboxCategoria.Items.Add(categoria.nombre);
                }

                var categoriaSeleccionada = (Categoria)this.filaSeleccionada.Cells["categoria"].Value;

                cboxCategoria.SelectedIndex = this.listaCategorias.FindIndex(c => c.nombre == categoriaSeleccionada.nombre);

                // Manejar el evento de cambiar la seleccion
                cboxCategoria.SelectedIndexChanged += (sender, e) =>
                {
                    int selectedIndex = cboxCategoria.SelectedIndex;
                    long selectedId = this.listaCategorias[selectedIndex].id;
                    Console.WriteLine("ID del elemento seleccionado: " + selectedId);
                };
            }
        }

        private bool validarCampos()
        {
            var nombre = tboxNombre.Text;
            var stock = tboxStock.Value;
            var precio = tboxPrecio.Value;
            var descripcion = tboxDescripcion.Text;

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

        private void editarProducto()
        {
            if (validarCampos() == false)
            {
                return;
            }

            int selectedIndex = cboxCategoria.SelectedIndex;
            long selectedId = this.listaCategorias[selectedIndex].id;

            string nombre = tboxNombre.Text;
            string sku = this.filaSeleccionada.Cells["sku"].Value.ToString();
            long stock = long.Parse(tboxStock.Text);
            float precio = float.Parse(tboxPrecio.Text);
            string descripcion = tboxDescripcion.Text;
            string alto = tboxAlto.Text;
            string ancho = tboxAncho.Text;
            string peso = tboxPeso.Text;
            Categoria categoria = new Categoria() 
            {
                id = selectedId
            };
            //string imagen = tboxDescripcion.Text;

            var producto = new Producto
            {
                id = long.Parse(sku),
                sku = sku,
                nombre = nombre,
                stock = stock,
                precio = precio,
                descripcion = descripcion,
                alto = alto,
                ancho = ancho,
                peso = peso,
                categoria = categoria
            };

            string c = JsonConvert.SerializeObject(categoria);
            Console.WriteLine(c);

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

                    //CargarProductos();
                    MessageBox.Show("¡Editado correctamente!");
                    this.Close();
                }
            }
            catch (WebException ex)
            {
                // Manejar errores de red o de la API
                MessageBox.Show("Error en la solicitud: " + ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            editarProducto();
        }
    }
}
