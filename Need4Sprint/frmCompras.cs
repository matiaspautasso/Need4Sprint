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
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();
        }



        private void gestionDeInventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuRegistro_Click(object sender, EventArgs e)
        {
            frmRegCompras fr = new frmRegCompras();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {

        }
    }
}
