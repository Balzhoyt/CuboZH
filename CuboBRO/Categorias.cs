using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuboBRO
{
    class Categorias
    {
        
        DataSet ds = new DataSet();

        public Categorias()
        {
            

            //declaramos las variables         
            OleDbConnection conexion = null;
            // DataSet dataSet = null;
            OleDbDataAdapter dataAdapter = null;

            //string consultaHojaExcel = "Select * from [" + hoja + "$]";
            string consultaHojaExcel = "Select * from [Hoja1$]";
            //esta cadena es para archivos excel 2007 y 2010
            string cadenaConexionArchivoExcel = "provider=Microsoft.ACE.OLEDB.12.0;Data Source='d:\\Data\\categorias.xlsx';Extended Properties=Excel 12.0;";

                try
                {
                   
                    //Si el usuario escribio el nombre de la hoja se procedera con la busqueda
                    conexion = new OleDbConnection(cadenaConexionArchivoExcel);//creamos la conexion con la hoja de excel
                    conexion.Open(); //abrimos la conexion
                    dataAdapter = new OleDbDataAdapter(consultaHojaExcel, conexion); //traemos los datos de la hoja y las guardamos en un dataSdapter
                    //  dataSet = new DataSet(); // creamos la instancia del objeto DataSet
                   
                    dataAdapter.Fill(ds);//llenamos el dataset
                   
                }
                catch (Exception ex)
                {
                   
                }

        }



       public  String getCategoria(string producto)
        {

            var valor = "";
            var cat = "miselanea";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                valor=ds.Tables[0].Rows[i][1].ToString();
                if (producto == valor)
                {
                    cat= ds.Tables[0].Rows[i][2].ToString();
                    break;
                }
            }
          

            return cat;
        }


    }
}
