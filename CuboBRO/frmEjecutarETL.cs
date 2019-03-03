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
    public partial class frmEjecutarETL : Form
    {
        private int ID_VENTA = 0; // variables globales que se iran incrementando cada que se regsitren los tickets
        private int ID_TIEMPO = 0;
        private int ID_PRODUCTO = 0;

        public frmEjecutarETL()
        {
            InitializeComponent();
        }

        private void btnAceptarETL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEjecutarETL_Load(object sender, EventArgs e)
        {
            ExtraccionDatos();
        }

        void ExtraccionDatos() {

            frmCargarDatos frmCargarDatos = new frmCargarDatos(); pb(2);
            DataSet dsNeto = new DataSet();
            DataSet dsBodega = new DataSet();
            DataSet dsSoriana = new DataSet();
            dsNeto = frmCargarDatos.dsNeto; pb(10);
            dsBodega = frmCargarDatos.dsBodega; pb(15);
            dsSoriana = frmCargarDatos.dsSoriana; pb(20);
            if ((dsNeto.Tables.Count != 0)&&(dsBodega.Tables.Count != 0) && (dsSoriana.Tables.Count != 0)) {//verifica si tiene datos, se hace la carga.
                TransformacionCargaDatosNeto(dsNeto); 
                TransformacionCargaDatosBodegaAurrera(dsBodega);
            }
            else
            {
                MessageBox.Show("No hay datos, se redireccionará a cargarlos","NO HAY DATOS QUE PROCESAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                frmCargarDatos.Show();
            }
            pb(100);
            //this.Close();
                        
        }

        void TransformacionCargaDatosNeto(DataSet dsNeto)
        {
            int id_tienda = 0;
            int id_producto=ID_PRODUCTO;
            int id_venta=ID_VENTA;
            int id_tiempo=ID_TIEMPO;
            string sql;

            SQL sqlBD = new SQL();
            //Registramos la tienda en la base de datos
            if (!sqlBD.Existe(id_tienda, "SELECT COUNT(*) FROM dimTienda WHERE id_tienda = @Id"))//comrueba si el producto exite para ya no agregarlo
            {
                sql = "insert into dimTienda(id_tienda,nombre) values(" + id_tienda + ",'Neto') ";
                sqlBD.EjecutaSQLComando(sql);

           
                pb(25);

                //leer las columnas del dataset para tratar los productos
                var hora = "";
                var venta = 0.0;
                var precio = 0.0;
                var cantidad = 0.0;
                var producto = "";
                for (int i = 0; i < dsNeto.Tables[0].Rows.Count; i++)
                {
                    id_tiempo = i;
                    id_venta = i;
                    var valor = dsNeto.Tables[0].Rows[i][5 + i].ToString();
                    hora = dsNeto.Tables[0].Rows[i][3].ToString();
                    venta = float.Parse(dsNeto.Tables[0].Rows[i][4].ToString());

                    sql = "insert into dimTiempo(id_tiempo,fecha,hora) values(" + id_tiempo + ",'2019/02/14','" + hora + "')"; //REGISTRA LA FECHA
                    sqlBD.EjecutaSQLComando(sql);

                    for (int j = 5; j < dsNeto.Tables[0].Columns.Count; j++)
                    {
                        cantidad = float.Parse(dsNeto.Tables[0].Rows[i][j].ToString());//obtiene la cantidad de los productos que se compraron 
                        if (cantidad != 0)
                        {
                            id_producto = j;
                            producto = dsNeto.Tables[0].Columns[j].ColumnName.ToString(); //obtine los nombrfes de las columnas que son los productos de las ventas
                            producto = producto.Replace("#", "."); //remplaza el # por el. ya que en la carga no se convierte bien ls valores
                            precio = float.Parse(producto.Substring(0, producto.IndexOf(" ") + 1)); //para extraer los primeros carateres hasta que encuentra el espacio en blanco que es el precio del producto
                            producto = producto.Remove(0, producto.IndexOf(" ") + 1); //Elimina el precio del producto

                            if (!sqlBD.Existe(id_producto, "SELECT COUNT(*) FROM dimProducto WHERE id_producto = @Id"))//comrueba si el producto exite para ya no agregarlo
                            {
                                sql = "insert into dimProducto(id_producto,nombre,categoria) values(" + id_producto + ",'" + producto + "','varios')";// REGISTRA EL PRODUCTO
                                sqlBD.EjecutaSQLComando(sql);
                            }

                            sql = "insert into hechosVentas(id_venta,id_tienda,id_tiempo,id_producto,unidades,precio) " +
                                                    " values(" + id_venta + "," + id_tienda + "," + id_tiempo + "," + id_producto + "," + cantidad + "," + precio + ")"; //REGISTRA LA VENTA
                            sqlBD.EjecutaSQLComando(sql);
                            ID_PRODUCTO++; //incrementamos la variable global
                        }
                    }
                    ID_TIEMPO++;//incrementamos la variable global
                    ID_VENTA++;//incrementamos la variable global
                }
            }
            pb(90);
        }

        void TransformacionCargaDatosBodegaAurrera(DataSet dsBodega)
        {
            int id_tienda = 1;
            int id_producto=ID_PRODUCTO;
            int id_venta=ID_VENTA;
            int id_tiempo=ID_TIEMPO;
            string sql;

            SQL sqlBD = new SQL();
            //Registramos la tienda en la base de datos
            if (!sqlBD.Existe(id_tienda, "SELECT COUNT(*) FROM dimTienda WHERE id_tienda = @Id"))//comrueba si el producto exite para ya no agregarlo
            {
                sql = "insert into dimTienda(id_tienda,nombre) values(" + id_tienda + ",'Bodega Aurrera') ";
                sqlBD.EjecutaSQLComando(sql);
                pb(25);
                //leer las columnas del dataset para tratar los productos
                var hora = "";
                var venta = 0.0;
                var precio = 0.0;
                var cantidad = 0.0;
                var producto = "";
                for (int i = 0; i < dsBodega.Tables[0].Rows.Count; i++)
                {
                    id_tiempo = ID_TIEMPO + i+1;
                    id_venta = ID_VENTA;
                    //var valor = dsBodega.Tables[0].Rows[i][5 + i].ToString();
                    hora = "12:00:00"; // se pone esta hora porque los datos de Bodega Aurrera los omitio
                    //venta = float.Parse(dsBodega.Tables[0].Rows[i][4].ToString());

                    sql = "insert into dimTiempo(id_tiempo,fecha,hora) values(" + id_tiempo + ",'2019/02/14','" + hora + "')"; //REGISTRA LA FECHA
                    sqlBD.EjecutaSQLComando(sql);

                    for (int j = 5; j < dsBodega.Tables[0].Columns.Count; j++)
                    {
                        cantidad = float.Parse(dsBodega.Tables[0].Rows[i][j].ToString());//obtiene la cantidad de los productos que se compraron 
                        if (cantidad != 0)
                        {
                            id_producto = j;
                            producto = dsBodega.Tables[0].Columns[j].ColumnName.ToString(); //obtine los nombrfes de las columnas que son los productos de las ventas
                            producto = producto.Replace("#", "."); //remplaza el # por el. ya que en la carga no se convierte bien ls valores
                            precio = float.Parse(producto.Substring(0, producto.IndexOf(" ") + 1)); //para extraer los primeros carateres hasta que encuentra el espacio en blanco que es el precio del producto
                            producto = producto.Remove(0, producto.IndexOf(" ") + 1); //Elimina el precio del producto

                            if (!sqlBD.Existe(id_producto, "SELECT COUNT(*) FROM dimProducto WHERE id_producto = @Id"))//comrueba si el producto exite para ya no agregarlo
                            {
                                sql = "insert into dimProducto(id_producto,nombre,categoria) values(" + id_producto + ",'" + producto + "','varios')";// REGISTRA EL PRODUCTO
                                sqlBD.EjecutaSQLComando(sql);
                            }

                            sql = "insert into hechosVentas(id_venta,id_tienda,id_tiempo,id_producto,unidades,precio) " +
                                                    " values(" + id_venta + "," + id_tienda + "," + id_tiempo + "," + id_producto + "," + cantidad + "," + precio + ")"; //REGISTRA LA VENTA
                            sqlBD.EjecutaSQLComando(sql);
                        }
                    }
                }
            }
            pb(90);
        }
        void pb(int valor)
        {
            progressBar1.Value = valor;
        }
    }
}
