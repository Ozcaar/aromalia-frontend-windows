using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Aromalia.FormInventario;

namespace Aromalia
{
    public partial class FormVentas : Form
    {

        public class Metodo
        {
            public long id { get; set; }
            public string nombre { get; set; }
        }

        public class Venta
        {
            public long id { get; set; }
            public string factura { get; set; }
            public string fecha {  get; set; }
            public float total { get; set; }
            public Metodo metodo { get; set; }
        }

        private DataGridViewRow filaSeleccionada;
        List<Metodo> listaMetodos;
        private List<Venta> ventas;
        private string apiURL;

        public FormVentas()
        {
            InitializeComponent();
            ventas = new List<Venta>();
            apiURL = "http://localhost:8080";
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            cargarMetodos();
            CargarVentas();
        }

        private void CargarVentas()
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    // Especificar la codificación UTF-8
                    wc.Encoding = Encoding.UTF8;

                    //Descargar los datos de la api en formato JSON
                    string json = wc.DownloadString(apiURL + "/ventas");

                    //Convertir el JSON en una lista de objetos
                    var datos = JsonConvert.DeserializeObject<List<Venta>>(json);

                    List<Venta> listaVentas = JsonConvert.DeserializeObject<List<Venta>>(json);

                    ventas = listaVentas;


                    // Llenar el DataGridView con los datos
                    //inventarioTabla_dgv.DataSource = datos;
                    ventasTabla_dgv.DataSource = ventas;

                    // Agrega el evento CellFormatting al DataGridView
                    ventasTabla_dgv.CellFormatting += (sender, e) =>
                    {
                        if (e.ColumnIndex == ventasTabla_dgv.Columns["Metodo"].Index && e.Value != null)
                        {
                            // Verifica que el valor no sea nulo y que sea de tipo Categoria
                            if (e.Value is Metodo metodo)
                            {
                                // Asigna el valor de la propiedad Nombre_categoria al valor de la celda
                                e.Value = metodo.nombre;
                            }
                        }
                    };

                    //inventarioTabla_dgv.Columns["Nombre"].HeaderText = "Nombre del Producto";
                }
            }
            catch (Exception ex)
            {
                //Mostrar mensaje de error
                MessageBox.Show("Error al descargar los datos: " + ex.Message);
            }
        }
                                                                                                 
        private void ventasTabla_dgv_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {


        }
        private void cargarMetodos()
        {
            using (WebClient wc = new WebClient())
            {
                // Especificar la codificación UTF-8
                wc.Encoding = Encoding.UTF8;

                //Descargar los datos de la api en formato JSON
                string json = wc.DownloadString(apiURL + "/metodos");

                //Convertir el JSON en una lista de objetos
                this.listaMetodos = JsonConvert.DeserializeObject<List<Metodo>>(json);



                // Rellenar el ComboBox
                foreach (var metodo in this.listaMetodos)
                {
                    cbox_metodo.Items.Add(metodo.nombre);
                }

                //if (ventasTabla_dgv.SelectedRows.Count > 0)
                //{
                    // Obtener el índice de la fila seleccionada
                //    int rowIndex = ventasTabla_dgv.SelectedRows[0].Index;
                //    this.filaSeleccionada = ventasTabla_dgv.Rows[rowIndex];

                //    var metodoSeleccionado = (Metodo)this.filaSeleccionada.Cells["metodo"].Value;
                //    cbox_metodo.SelectedIndex = this.listaMetodos.FindIndex(c => c.nombre == metodoSeleccionado.nombre);

                    // Manejar el evento de cambiar la seleccion
                //    cbox_metodo.SelectedIndexChanged += (sender, e) =>
                //    {
                //        int selectedIndex = cbox_metodo.SelectedIndex;
                //        long selectedId = this.listaMetodos[selectedIndex].id;
                //        Console.WriteLine("ID del elemento seleccionado: " + selectedId);
                //    };
                //}
            }
        }

        private void ventasTabla_dgv_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada
            if (ventasTabla_dgv.SelectedRows.Count > 0)
            {
                // Obtiene el índice de la fila seleccionada
                int rowIndex = ventasTabla_dgv.SelectedRows[0].Index;

                // Accede a la fila seleccionada
                DataGridViewRow filaSeleccionada = ventasTabla_dgv.Rows[rowIndex];

                // Accede a los valores de las celdas de la fila seleccionada usando el índice de columna o el nombre de la columna
                string factura = filaSeleccionada.Cells["factura"].Value.ToString();
                DateTime fecha;
                if (!DateTime.TryParse(filaSeleccionada.Cells["fecha"].Value.ToString(), out fecha))
                {
                    fecha = DateTime.Now;
                }
                float total;
                if (!float.TryParse(filaSeleccionada.Cells["total"].Value.ToString(), out total))
                {
                    total = 0.0f;
                }


                // Cambiar el método seleccionado al seleccionar otra fila en el combobox
                var metodoSeleccionado = (Metodo)filaSeleccionada.Cells["metodo"].Value;

                // Asignar valores a las casillas en función a la fila seleccionada
                cbox_metodo.SelectedIndex = this.listaMetodos.FindIndex(m => m.nombre == metodoSeleccionado.nombre);
                tbox_total.Text = total.ToString();
                dpick_fecha.Value = fecha;
                tbox_factura.Text = factura;
            }
        }
    }
}
