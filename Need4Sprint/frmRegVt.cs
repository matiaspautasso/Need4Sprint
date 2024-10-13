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
    public partial class frmRegVt : Form
    {
        public frmRegVt()
        {
            InitializeComponent();
        }

        private void frmRegVt_Load(object sender, EventArgs e)
        {
            DgvMostrar.ColumnHeadersDefaultCellStyle.Font = new Font(DgvMostrar.Font, FontStyle.Bold);
            DgvMostrar.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14);
        }
    }
}
