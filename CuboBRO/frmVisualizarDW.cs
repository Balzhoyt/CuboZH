using System;
using System.Windows.Forms;

namespace CuboBRO
{
    public partial class frmVisualizarDW : Form
    {
        public frmVisualizarDW()
        {
            InitializeComponent();
        }

        private void tpEsquema_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptarAlmacen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVisualizarDW_Load(object sender, EventArgs e)
        {
            visualizarAlmacenDW();
        }

        private void visualizarAlmacenDW()
        {
            SQL sqlDB = new SQL();
            
            dwvTiendas.DataSource=sqlDB.DataSetSQL("SELECT * FROM dimTienda ORDER BY id_tienda").Tables[0];//obtener los datos de la tabla dimTienda
            dwvProductos.DataSource= sqlDB.DataSetSQL("SELECT * FROM dimProducto ORDER BY id_producto").Tables[0];//obtener los datos de la tabla dimProductos
            dwvTiempo.DataSource = sqlDB.DataSetSQL("SELECT * FROM dimTiempo ORDER BY id_tiempo").Tables[0];//obtener los datos de la tabla dimTiempo
            dwvVentas.DataSource = sqlDB.DataSetSQL("SELECT * FROM vVentas ORDER BY id_venta").Tables[0];//obtener los datos de la vista vVentas
            dwvVentasCategorizadas.DataSource = sqlDB.DataSetSQL("SELECT * FROM vVentasCategorizadas ORDER BY id_venta").Tables[0];//obtener los datos de la vista vVentas
        }

        private void btnVaciarAlmacen_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Se eliminarán todos los registros de la base de datos", "Vaciar Almacen", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


            if (result == DialogResult.Yes)
            {
                //limpiamos los DataWridViews 
                dwvTiendas.DataSource = null;
                dwvTiendas.Refresh();

                dwvProductos.DataSource = null;
                dwvProductos.Refresh();

                dwvTiempo.DataSource = null;
                dwvTiempo.Refresh();

                dwvVentas.DataSource = null;
                dwvVentas.Refresh();

                //Eliminamos todos los registros del almacen con un procedimiento almacenmado
                SQL sqlDB = new SQL();
                var var = sqlDB.EjecutaSQLScalar("exec paVaciarAlmacen");
            }

                    
            
        }
    }
}
