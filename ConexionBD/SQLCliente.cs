using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace UberFrba.ConexionBD
{
    public class SQLCliente:ConexionSQL
    {
        static SqlCommand sqlCommand = new SqlCommand();
        

        public static void insertarCliente(UberFrba.Objetos.Cliente clie) {
        try{
            conectar();
            
            sqlCommand = new SqlCommand("insertar_cliente");
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Connection = miConexion;
 
 
            sqlCommand.Parameters.AddWithValue("@nombre", clie.nombre);
            sqlCommand.Parameters.AddWithValue("@apellido", clie.apellido);
            sqlCommand.Parameters.AddWithValue("@dni", clie.dni);
            sqlCommand.Parameters.AddWithValue("@mail", clie.mail);
            sqlCommand.Parameters.AddWithValue("@telefono", clie.telefono);
            sqlCommand.Parameters.AddWithValue("@direccion", clie.direccion);
            sqlCommand.Parameters.AddWithValue("@piso", clie.piso);
            sqlCommand.Parameters.AddWithValue("@depto", clie.depto);
            sqlCommand.Parameters.AddWithValue("@localidad", clie.localidad);
            sqlCommand.Parameters.AddWithValue("@codPostal", clie.codPostal);
            sqlCommand.Parameters.AddWithValue("@fechaNacimiento", clie.fechaNacimiento);

            sqlCommand.ExecuteNonQuery();
 
        } catch(Exception ex){
           //Manejar errores
            
        }finally{
            desconectar();
        }
    }  

        /*
        public DataTable mostrar() {
        try {
            conectado();
            cmd = new SqlCommand("mostrar_cliente");
            cmd.CommandType = CommandType.StoredProcedure;
 
            cmd.Connection = cnn;
 
            if( cmd.ExecuteNonQuery ){
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }else{
                return null;
            }
        }catch(Exception ex){
            MsgBox(ex.Message);
            return null;
        }finally{
            desconectado();
        }
    }  */


        internal static void insertar(Objetos.Cliente clie)
        {
            throw new NotImplementedException();
        }
    }
}

/*

using System.Data.SqlClient;
 
 
public class fcliente:conexion{
    SqlCommand cmd = new SqlCommand();
 
    
 
 
   
 
 
 
    public bool editar(vcliente dts) {
        try{
            conectado();
            cmd = new SqlCommand("editar_cliente");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
 
            cmd.Parameters.AddWithValue("@idcliente", dts.gidcliente);
            cmd.Parameters.AddWithValue("@nombre", dts.gnombres);
            cmd.Parameters.AddWithValue("@apellidos", dts.gapellidos);
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion);
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono);
            cmd.Parameters.AddWithValue("@dni", dts.gdni);
 
            if( cmd.ExecuteNonQuery ){
                return true;
            }else{
                return false;
            }
 
        }catch(Exception ex){
            MsgBox(ex.Message);
            return false;
        }finally{
            desconectado();
        }
    }  
    public bool eliminar(vcliente dts) {
        try{
            conectado();
            cmd = new SqlCommand("eliminar_cliente");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
 
            cmd.Parameters.Add("@idcliente", SqlDbType.NVarChar, 50).Value = dts.gidcliente;
            if( cmd.ExecuteNonQuery ){
                return true;
            }else{
                return false;
            }
        }catch(Exception ex){
            MsgBox(ex.Message);
            return false;
 
        }
    }  
 
}
*/

