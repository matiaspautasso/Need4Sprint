using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Need4Sprint
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblCrear_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario FrmCrearCta
            FrmCrearCta frmCrear = new FrmCrearCta();

            // Ocultar el formulario frmLogin
            this.Hide();

            // Mostrar el formulario FrmCrearCta de manera modal
            frmCrear.ShowDialog();

            // Mostrar nuevamente el formulario frmLogin después de cerrar FrmCrearCta
            this.Show();
        }
    }
}
