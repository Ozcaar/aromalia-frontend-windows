using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aromalia
{
    public partial class FormPanel : Form
    {
        public FormPanel(string usuario)
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            openChildForm(new FormInventario());
            btn_inventario.Checked = true;
            btn_ventas.Checked = false;
            btn_pedidos.Checked = false;
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            openChildForm(new FormVentas());
            btn_inventario.Checked = false;
            btn_ventas.Checked = true;
            btn_pedidos.Checked = false;
        }

        private void btn_pedidos_Click(object sender, EventArgs e)
        {
            btn_inventario.Checked = false;
            btn_ventas.Checked = false;
            btn_pedidos.Checked = true;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
