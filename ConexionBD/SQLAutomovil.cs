using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using UberFrba.Objetos;

namespace UberFrba.ConexionBD
{
    public class SQLAutomovil:ConexionSQL
    {
        static SqlCommand sqlCommand = new SqlCommand();
        

        public static string insertarAutomovil(Automovil auto) {
            conectar();

            sqlCommand = new SqlCommand("NONAME.sproc_automovil_alta");
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Connection = miConexion;
           
            sqlCommand.Parameters.AddWithValue("@patente_auto", auto.patente);
            sqlCommand.Parameters.AddWithValue("@modelo", auto.modelo);
            sqlCommand.Parameters.AddWithValue("@id_turno", auto.idturno);
            sqlCommand.Parameters.AddWithValue("@id_marca", auto.idmarca);
            sqlCommand.Parameters.AddWithValue("@rodado", auto.rodado);
            sqlCommand.Parameters.AddWithValue("@habilitado", auto.habilitado);
            sqlCommand.Parameters.AddWithValue("@licencia", auto.licencia);
            sqlCommand.Parameters.AddWithValue("@id_chofer", auto.idchofer);
            int response=sqlCommand.ExecuteNonQuery();
            if (response == 0)
            {
                return "No pudo realizarse la alta";
            }
            else{
                return "Alta realizada";
            }
    }
        public static List<String> obtain_marcas() {
            SqlConnection miConexion = new SqlConnection(ConexionSQL.cadenaConexion());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT id_marca,nombre FROM Noname.Marca";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = miConexion;


            System.Console.Write(cmd.CommandText);

            miConexion.Open();

            reader = cmd.ExecuteReader();
            List<String> marcas=new List<string>();
            while (reader.Read())
            {
                marcas.Add("["+reader["id_marca"].ToString()+"] "+reader["nombre"].ToString());
            }
            return  marcas;  
        }
        public static DataTable filtrarAutomoviles(Automovil auto) {
            try {


                conectar();

                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "Select marca, modelo, patente, chofer" ;
                sqlCommand.CommandType = CommandType.Text; //Esto es opcional porque de base es un texto
                sqlCommand.Connection = miConexion;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableClientes = new DataTable();
                dataTableClientes.Load(sqlReader);
                return dataTableClientes;     
          
            }catch(Exception ex){
                //hacer algo con las exepciones
             
                return null;
            }finally{
                desconectar();
            }
        }

        public static DataTable obtenerTodosLosClientes()
        {
            try
            {
                //Falta depurar bien el select

                conectar();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT nombre, apellido, id_usuario_dni, mail, telefono, direccion, codigo_postal, fecha_nacimiento FROM NONAME.Usuario join NONAME.Cliente on id_usuario_dni = id_cliente";
                sqlCommand.CommandType = CommandType.Text; //opcional
                sqlCommand.Connection = miConexion;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableClientes = new DataTable();
                dataTableClientes.Load(sqlReader);
                return dataTableClientes;
            }
            catch (Exception ex)
            {
                //hacer algo con las exepciones
                return null;
            }
            finally
            {
                desconectar();
            }
        }

        public static void modificarCliente(Cliente clie)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.sproc_cliente_modificacion");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@nombre", clie.nombre);
                sqlCommand.Parameters.AddWithValue("@apellido", clie.apellido);
                sqlCommand.Parameters.AddWithValue("@id_usuario_dni", clie.dni);
                sqlCommand.Parameters.AddWithValue("@mail", clie.mail);
                sqlCommand.Parameters.AddWithValue("@telefono", clie.telefono);
                sqlCommand.Parameters.AddWithValue("@direccion", clie.direccion);
            //    sqlCommand.Parameters.AddWithValue("@localidad", clie.localidad);
                sqlCommand.Parameters.AddWithValue("@codigo_postal", clie.codPostal);
                sqlCommand.Parameters.AddWithValue("@fecha_nacimiento", clie.fechaNacimiento);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //manejar exepciones
            }
            finally
            {
                desconectar();
            }
        }

        public static void eliminarCliente(Cliente clie)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.sproc_cliente_baja");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@id_usuario_dni", clie.dni);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //manejar exepciones
            }
            finally
            {
                desconectar();
            }
        }
    }
}


