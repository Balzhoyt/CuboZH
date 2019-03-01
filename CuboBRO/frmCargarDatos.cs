using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuboBRO
{
    public partial class frmCargarDatos : Form
    {
        public static DataSet dsNeto = new DataSet();
        public static DataSet dsSoriana = new DataSet();
        public static DataSet dsBodega = new DataSet();

        public frmCargarDatos()
        {
            InitializeComponent();
        }

        private void LLenarGrid(string archivo, string hoja, DataGridView dataGridView,DataSet dataSet)
        {
            progressBar1.Value = 0;
            //declaramos las variables         
            OleDbConnection conexion = null;
           // DataSet dataSet = null;
            OleDbDataAdapter dataAdapter = null;

            //string consultaHojaExcel = "Select * from [" + hoja + "$]";
            string consultaHojaExcel = "Select * from [Hoja1$]";
            //esta cadena es para archivos excel 2007 y 2010
            string cadenaConexionArchivoExcel = "provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + archivo + "';Extended Properties=Excel 12.0;";

            if (string.IsNullOrEmpty(hoja))
            {
                MessageBox.Show("No hay una hoja para leer");
            }
            else
            {
                try
                {
                    progressBar1.Value = 50;
                    //Si el usuario escribio el nombre de la hoja se procedera con la busqueda
                    conexion = new OleDbConnection(cadenaConexionArchivoExcel);//creamos la conexion con la hoja de excel
                    conexion.Open(); //abrimos la conexion
                    dataAdapter = new OleDbDataAdapter(consultaHojaExcel, conexion); //traemos los datos de la hoja y las guardamos en un dataSdapter
                    //  dataSet = new DataSet(); // creamos la instancia del objeto DataSet
                    progressBar1.Value = 80;
                    dataAdapter.Fill(dataSet, hoja);//llenamos el dataset
                    dataGridView.DataSource = dataSet.Tables[0]; //le asignamos al DataGridView el contenido del dataSet
                    conexion.Close();//cerramos la conexion
                    dataGridView.AllowUserToAddRows = false;       //eliminamos la ultima fila del datagridview que se autoagrega
                    progressBar1.Value = 100;
                }
                catch (Exception ex)
                {
                    //en caso de haber una excepcion que nos mande un mensaje de error
                    MessageBox.Show("Error, Verificar el archivo o el nombre de la hoja", ex.Message);
                }
            }
        }

        private void btnCargarSoriana_Click(object sender, EventArgs e)
        {
            //creamos un objeto OpenDialog que es un cuadro de dialogo para buscar archivos
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos de Excel(*.xls; *.xlsx; *.csv)| *.xls; *.xlsx; *.csv"; //le indicamos el tipo de filtro en este caso que busque
                                                                             //solo los archivos excel

            dialog.Title = "Seleccione el archivo de Excel";//le damos un titulo a la ventana

            dialog.FileName = string.Empty;//inicializamos con vacio el nombre del archivo

            //si al seleccionar el archivo damos Ok
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //el nombre del archivo sera asignado al textbox
                txtArchivoTiendaNeto.Text = dialog.FileName;
                string hoja = "Hoja1";
                LLenarGrid(txtArchivoTiendaNeto.Text, hoja, dataGridViewSoriana,dsSoriana); //se manda a llamar al metodo

                dataGridViewSoriana.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; //se ajustan lascolumnas al ancho del DataGridview para que no quede espacio en blanco (opcional)
               
            }
        }

        private void btnCargarBodegaAurrera_Click(object sender, EventArgs e)
        {
            //creamos un objeto OpenDialog que es un cuadro de dialogo para buscar archivos
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos de Excel (*.xls;*.xlsx;*.csv)|*.xls;*.xlsx;*.csv"; //le indicamos el tipo de filtro en este caso que busque
                                                                             //solo los archivos excel

            dialog.Title = "Seleccione el archivo de Excel";//le damos un titulo a la ventana

            dialog.FileName = string.Empty;//inicializamos con vacio el nombre del archivo

            //si al seleccionar el archivo damos Ok


            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //el nombre del archivo sera asignado al textbox
                txtArchivoTiendaNeto.Text = dialog.FileName;
                string hoja = "Hoja1";
                LLenarGrid(txtArchivoTiendaNeto.Text, hoja, dataGridViewBodegaAurrera,dsBodega); //se manda a llamar al metodo

                dataGridViewBodegaAurrera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; //se ajustan lascolumnas al ancho del DataGridview para que no quede espacio en blanco (opcional)

            }

        }

        private void btCargarNeto_Click(object sender, EventArgs e)
        {
            //creamos un objeto OpenDialog que es un cuadro de dialogo para buscar archivos
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos de Excel (*.xls;*.xlsx;*.csv)|*.xls;*.xlsx;*.csv"; //le indicamos el tipo de filtro en este caso que busque
                                                                             //solo los archivos excel

            dialog.Title = "Seleccione el archivo de Excel";//le damos un titulo a la ventana

            dialog.FileName = string.Empty;//inicializamos con vacio el nombre del archivo

            //si al seleccionar el archivo damos Ok

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //el nombre del archivo sera asignado al textbox
                txtArchivoTiendaNeto.Text = dialog.FileName;
                string hoja = "Hoja1";
                LLenarGrid(txtArchivoTiendaNeto.Text, hoja, dataGridViewNeto,dsNeto); //se manda a llamar al metodo

                dataGridViewNeto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; //se ajustan lascolumnas al ancho del DataGridview para que no quede espacio en blanco (opcional)
            }
        }

        private void btnAceptarCargaDatos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    
}

