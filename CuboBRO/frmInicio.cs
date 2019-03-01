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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            frmCargarDatos frmCargarDatos = new frmCargarDatos();
            frmCargarDatos.Show();
        }

        private void btnEjecutarETL_Click(object sender, EventArgs e)
        {
            frmEjecutarETL frmEjecutarETL = new frmEjecutarETL();
            frmEjecutarETL.Show();
        }

        private void btnVisualizarDW_Click(object sender, EventArgs e)
        {
            frmVisualizarDW frmVisualizar = new frmVisualizarDW();
            frmVisualizar.Show();
        }

        private void btnConsultarCUBO_Click(object sender, EventArgs e)
        {
            frmConsultarCubo frmConsultarCubo = new frmConsultarCubo();
            frmConsultarCubo.Show();
        }
    }
}
