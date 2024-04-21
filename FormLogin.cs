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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // Crear ventana del panel y ocultar la ventana de login
            FormPanel formPanel = new FormPanel("Datos relevantes aquí");
            formPanel.FormClosing += (s, args) => this.Close(); // Suscribirse al evento FormClosing de formPanel
            this.Hide();
            formPanel.Show();
        }
    }
}
