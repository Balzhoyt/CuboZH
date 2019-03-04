﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuboBRO
{
    public partial class frmEjecutarETLBodega : Form
    {
        private int ID_VENTA = 0; // variables globales que se iran incrementando cada que se regsitren los tickets
        private int ID_TIEMPO = 0;
        private int ID_PRODUCTO = 0;
        private bool cargado = false;

        public frmEjecutarETLBodega()
        {
            InitializeComponent();
        }

        private void btnAceptarETL_Click(object sender, EventArgs e)
        {
            if (!cargado) { 
                ExtraccionDatos();
                btnAceptarETL.Visible=false;
                btnSalir.Visible = true;
                cargado = true;
            }
           
        }

        private void frmEjecutarETL_Load(object sender, EventArgs e)
        {

            
           
            
        }

        void ExtraccionDatos() {
            DataSet dsNeto = new DataSet();
            DataSet dsBodega = new DataSet();
            DataSet dsSoriana = new DataSet();
            dsNeto = frmCargarDatos.dsNeto; pb(10);
            dsBodega = frmCargarDatos.dsBodega; pb(15);
            dsSoriana = frmCargarDatos.dsSoriana; pb(20);
            if ((dsNeto.Tables.Count != 0) && (dsBodega.Tables.Count != 0) && (dsSoriana.Tables.Count != 0))
            {//verifica si tiene datos, se hace la carga.
                TransformacionCargaDatosNeto(dsNeto); pb(50);
                TransformacionCargaDatosBodegaAurrera(dsBodega); pb(70);
            }
            else
            {
                MessageBox.Show("No hay datos, se redireccionará a cargarlos", "NO HAY DATOS QUE PROCESAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmCargarDatos frmCargarDatos = new frmCargarDatos();
                frmCargarDatos.Show();
                this.Close();

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
                                ID_PRODUCTO++; //incrementamos la variable global
                            }

                            sql = "insert into hechosVentas(id_venta,id_tienda,id_tiempo,id_producto,unidades,precio) " +
                                                    " values(" + id_venta + "," + id_tienda + "," + id_tiempo + "," + id_producto + "," + cantidad + "," + precio + ")"; //REGISTRA LA VENTA
                            sqlBD.EjecutaSQLComando(sql);
                            
                        }
                        
                    }
                    ID_TIEMPO++;//incrementamos la variable global
                    ID_VENTA++;//incrementamos la variable global
                }
            }
            
        }

        void TransformacionCargaDatosBodegaAurrera(DataSet dsBodega)
        {
            int id_tienda = 1;
            ID_PRODUCTO = ID_PRODUCTO + 5;
            int id_producto=ID_PRODUCTO;
            int id_venta=ID_VENTA;
            int id_tiempo=ID_TIEMPO;
            string sql;
            string registrarVenta = "";

            SQL sqlBD = new SQL();
            //Registramos la tienda en la base de datos
            if (!sqlBD.Existe(id_tienda, "SELECT COUNT(*) FROM dimTienda WHERE id_tienda = @Id"))//comrueba si el producto exite para ya no agregarlo
            {
                sql = "insert into dimTienda(id_tienda,nombre) values(" + id_tienda + ",'Bodega Aurrera') ";
                sqlBD.EjecutaSQLComando(sql);
                
                //leer las columnas del dataset para tratar los productos
                var hora = "";
                var unidades = 0.0;
                var precio = 0.0;
                var cantidad = 0.0;
                var producto = "";
                for (int i = 0; i < dsBodega.Tables[0].Rows.Count; i++) //recorre la filas
                {
                    id_tiempo = ID_TIEMPO + i + 1;
                    id_venta = ID_VENTA;
                    hora = "12:00:00"; // se pone esta hora porque los datos de Bodega Aurrera los omitió
                    sql = "insert into dimTiempo(id_tiempo,fecha,hora) values(" + id_tiempo + ",'2019/02/14','" + hora + "')"; //REGISTRA LA FECHA
                    sqlBD.EjecutaSQLComando(sql);

                    for (int j = 0; j < dsBodega.Tables[0].Columns.Count; j = j + 3)//recorre las columnas
                    {
                        id_venta = ID_VENTA;
                        producto = dsBodega.Tables[0].Rows[i][j].ToString();
                        if (producto != "")
                        { //verifica si la celda esta vacia o no
                            id_producto = ID_PRODUCTO;
                            precio = double.Parse(dsBodega.Tables[0].Rows[i][j + 2].ToString());
                            if (!sqlBD.Existe(producto, "SELECT COUNT(*) FROM dimProducto WHERE nombre = @Id"))//comrueba si el producto exite para ya no agregarlo
                            {
                                sql = "insert into dimProducto(id_producto,nombre,categoria) values(" + id_producto + ",'" + producto + "','varios')";// REGISTRA EL PRODUCTO
                                sqlBD.EjecutaSQLComando(sql);
                                unidades = 1;
                                ID_PRODUCTO++;
                                registrarVenta = "si";

                            }
                            else {
                                unidades++;
                                sql = "update hechosVentas set unidades=" + unidades + " where id_venta=" + id_venta; //si ya existe el producto en la misma venta, actualiza la cantidad
                                sqlBD.EjecutaSQLComando(sql);
                                id_producto--;
                                registrarVenta = "no";

                            }
                            if (registrarVenta=="si")
                            {
                                sql = "insert into hechosVentas(id_venta,id_tienda,id_tiempo,id_producto,unidades,precio) " +
                                                  " values(" + id_venta + "," + id_tienda + "," + id_tiempo + "," + id_producto + "," + unidades + "," + precio + ")"; //REGISTRA LA VENTA
                                sqlBD.EjecutaSQLComando(sql);

                            }


                        }


                    }
                    ID_VENTA++;

                }
            }
        
        }
        void pb(int valor)
        {
            progressBar1.Value = valor;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
