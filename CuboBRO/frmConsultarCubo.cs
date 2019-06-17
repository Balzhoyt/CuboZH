using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BAL;
using Apriori;
using System.IO;

namespace CuboBRO
{
    public partial class frmConsultarCubo : Form

    {
        SQL sqlDB = new SQL();
        public frmConsultarCubo()
        {
            InitializeComponent();
            
        }

        private void btnAceptarCUBO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dwvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEjecutarSQL_Click(object sender, EventArgs e)
        {
           
           
        }

        private void cmbConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index =cmbConsultas.SelectedIndex;
            switch (index)
            {
                case 0:ventasCategorizadas();break;
                case 1:VentasCategorizadasTotal(); break;
                case 2: VentasCategorizadasPorTienda(); break;
                default:
                    break;
            }
        }

        private void VentasCategorizadasPorTienda()
        {
            var query = "select * from vVentasCategorizadasPorTienda";
            dwvCubo.DataSource = sqlDB.DataSetSQL(query).Tables[0];//poblar el dw con culaquier consulta
        }

        private void VentasCategorizadasTotal()
        {
            var query = "select * from vVentasCategorizadasTotal";
            dwvCubo.DataSource = sqlDB.DataSetSQL(query).Tables[0];//poblar el dw con culaquier consulta
        }

        private void ventasCategorizadas()
        {
            string path = "D:/TransaccionesCUBOZH.txt";
            var query = "select * from vVentasCategorizadas order by id_venta";
            dwvCubo.DataSource = sqlDB.DataSetSQL(query).Tables[0];//poblar el dw con culaquier consulta
            var producto = "";
            var productotemp = "";
            for (int i = 0; i < dwvCubo.RowCount-1; i++)
            {
                for (int j = 3; j < dwvCubo.ColumnCount-1; j++)
                {
                    var dato = int.Parse(dwvCubo[j, i].Value.ToString());
                    if (dato!=0)
                    {
                        productotemp = dwvCubo.Columns[j].Name.ToString();
                        producto = producto + " " + productotemp;
                    } 
                }
                File.AppendAllLines(path, new String[] { producto });
                producto = "";
            }
           

        }

        

       
       
        private void ventasPorTienda()
        {
            string[] series;
            float[] points;
            Series Series = new Series();
                      
            var query = "select * from vVentasTiendas";
            dwvCubo.DataSource = sqlDB.DataSetSQL(query).Tables[0];//poblar el dw con culaquier consulta
            series = new string[5];
            points = new float[5];

            // Establecer paleta.
            this.chart1.Palette = ChartColorPalette.SeaGreen;

            // Establecer título.
            this.chart1.Titles.Add("Ventas por Tienda");
            for (int fila = 0; fila < dwvCubo.Rows.Count - 1; fila++)
            {
                var valor = dwvCubo.Rows[fila].Cells[0].Value.ToString();
                var valor2 = dwvCubo.Rows[fila].Cells[1].Value.ToString();

                Series = this.chart1.Series.Add(valor);
                Series.Points.Add(Double.Parse(valor2));
            }
            /*
           for (int i = 0; i < length; i++)
           {

               // Añadir serie.
               seriesArray[fila] = valor;
               Series series = this.chart1.Series.Add(seriesArray[fila]);
               pointsArray[col] = float.Parse(valor2);
               // Añadir punto.
               series.Points.Add(pointsArray[col]);
           }
           */
        }

        private void btnCrearReglas_Click(object sender, EventArgs e)
        {
            
            MainForm frmApriori = new MainForm();
            frmApriori.Show();

        }


    }
}
