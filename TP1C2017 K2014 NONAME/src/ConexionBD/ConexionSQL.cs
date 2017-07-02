using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using UberFrba.Properties;

namespace UberFrba.ConexionBD
{
    public class ConexionSQL
    {
        public static SqlConnection miConexion;

        public static String cadenaConexion(){
            return Settings.Default.conector;
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

       /* public static int insertar(dynamic parametros, string tabla)
        {
            List<String> campos = new List<String>();
            List<String> valores = new List<String>();
            List<String> variables_valores = new List<String>();
            foreach (var parametro in parametros)
            {
                campos.Add(parametro.Key);
                variables_valores.Add("@"+parametro.Key);
                valores.Add(parametro.Value);
                
            }
            String query = "INSERT INTO "+tabla+"("+String.Join(", ", campos.ToArray())+") VALUES("+String.Join(", ", variables_valores.ToArray())+")";

            SqlCommand command = new SqlCommand(query, miConexion);

            foreach(var valor in valores.ToArray()){
                command.Parameters.AddWithValue(variables_valores[valores.IndexOf(valor)], valor);
            }

            return command.ExecuteNonQuery();

        }*/

    }
}
