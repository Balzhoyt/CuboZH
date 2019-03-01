using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuboBRO
{
    public partial class frmPrincipalMDI : Form
    {
        public frmPrincipalMDI()
        {
            InitializeComponent();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frmPrincipalMDI_Load(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            frmInicio.MdiParent = this;
            frmInicio.Show();
                
        }

        private void procesoETLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
