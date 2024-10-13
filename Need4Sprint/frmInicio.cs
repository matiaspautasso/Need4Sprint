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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void registroDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegVt frmreg = new frmRegVt();
            this.Hide();
            frmreg.ShowDialog();
            this.Show();
        }

        private void historialDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHisVt frmhis = new frmHisVt();
            this.Hide();
            frmhis.ShowDialog();
            this.Show();
        }

        private void estadísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadis frmEsta = new frmEstadis();
            this.Hide();
            frmEsta.ShowDialog();
            this.Show();
        }

        private void crearCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearCta fr=new FrmCrearCta();   
            fr.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
    }
}
