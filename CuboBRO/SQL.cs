using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Drawing;


namespace CuboBRO
{
    class SQL

    {

        /// <summary> 
        /// Conexión a la Base de Datos con SQLOLEDB 
        /// </summary> 
        /// <returns>string de Conexión a la Base de Datos</returns> 
        public string GetConnectionString()
        {
            return "Data Source = ALIENWARE-BRO; Initial Catalog = TiendasMisantlaDW; Integrated Security = True";
        }

        int count;
        public bool Existe(int id, string query)
        {
            SqlConnection sqlConn = new SqlConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                sqlConn.ConnectionString = GetConnectionString();
                cmd.Parameters.AddWithValue("Id", id);
                sqlConn.Open();

                count = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception error)
            {
               // MessageBox.Show(error.ToString());
            }
            finally
            {
                sqlConn.Close();
            }
            if (count == 0)
                return false;
            else
                return true;
        }
        public bool Existe(string id, string query)
        {
            SqlConnection sqlConn = new SqlConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                sqlConn.ConnectionString = GetConnectionString();
                cmd.Parameters.AddWithValue("Id", id);
                sqlConn.Open();

                count = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception error)
            {
              //  MessageBox.Show(error.ToString());
            }
            finally
            {
                sqlConn.Close();
            }
            if (count == 0)
                return false;
            else
                return true;
        }

        /// <summary> 
        /// Ejecuta un comando SQL 
        /// </summary> 
        /// <param name="sComandoSql">Comando SQL para ejecutar Insert, Delete y Update</param> 
        public void EjecutaSQLComando(string sComandoSql)
        {
            SqlConnection sqlConn = new SqlConnection();
            SqlCommand sqlCom = new SqlCommand();
            try
            {
                sqlConn.ConnectionString = GetConnectionString();
                sqlConn.Open();
                sqlCom.Connection = sqlConn;
                sqlCom.CommandText = sComandoSql;
                sqlCom.ExecuteNonQuery();
            }
            catch (Exception error)
            {
               // MessageBox.Show(error.ToString());
            }
            finally
            {
                sqlConn.Close();
            }
        }


        /// <summary> 
        /// Ejecuta un comando SQL y retorna un parámetro 
        /// </summary> 
        /// <param name="sComandoSql">Comando SQL</param> 
        public string EjecutaSQLScalar(string sComandoSql)
        {
            var regreso = "0";
            SqlConnection sqlConn = new SqlConnection();
            SqlCommand sqlCom = new SqlCommand();
            try
            {
                sqlConn.ConnectionString = GetConnectionString();
                sqlConn.Open();
                sqlCom.Connection = sqlConn;
                sqlCom.CommandText = sComandoSql;
                sqlCom.ExecuteScalar();
                regreso = "1";
            }
            catch (Exception error)
            {

               // MessageBox.Show(error.ToString()); 
            }
            finally
            {
                sqlConn.Close();
            }
            return  regreso;
        }
        /// <summary> 
        /// Esta Función Sirve para llenar GridsView y Combos 
        /// Regresa un DataSet por lo que puede servir para mas 
        /// Controles de Datos 
        /// </summary> 
        /// <param name="mysql">mySql es la Sentencia en a Ejecutar para el llenado del Control</param> 
        /// <returns>Dataset para su llenado,DataGrids, Combos, etc</returns> 
        public DataSet LLenaComboGrid(string mysql)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cnn.ConnectionString = GetConnectionString();
                cnn.Open();
                cmd.CommandText = mysql;
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = cnn;
                da.Fill(ds);
            }
            catch (System.Data.SqlClient.SqlException error)
            {
                //MessageBox.Show(error.ToString());
            }
            cnn.Close();
            return ds;
        }

        public DataSet DataSetSQL(string query)

        {

            DataSet dsRetorno = new DataSet();

            using (SqlConnection sqlConn = new SqlConnection(this.GetConnectionString()))

            using (SqlCommand sqlCmd = new SqlCommand(query, sqlConn))

            using (SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd))

            {
                try
                {
                      sqlDA.Fill(dsRetorno);
                }
                catch (System.Data.SqlClient.SqlException error)
                {
                    MessageBox.Show(error.ToString());
                }
                
                

            }

            return dsRetorno;

        }

    }
}



