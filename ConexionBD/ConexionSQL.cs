using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UberFrba.ConexionBD
{
    public class ConexionSQL
    {
        public static SqlConnection miConexion;

        private static String cadenaConexion(){
            return @"Data Source=localhost\SQLSERVER2012; Initial Catalog=gd1c2017; User ID=gd; Password=gd2017;"
// @"Data Source= localhost; Initial Catalog=gd1c2017;integrated security= true";
        }
        
        //Metodo para conectar la base
        public static void conectar(){
            miConexion = new SqlConnection(cadenaConexion());
            miConexion.Open();
        }

        //Metodo para desconectar la base
        public static void desconectar(){
            miConexion.Close();
        }
    }
}
