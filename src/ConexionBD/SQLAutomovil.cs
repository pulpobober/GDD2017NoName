﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using UberFrba.Objetos;
using System.Diagnostics;

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

        public static string obtainHabilitado(int idautomovil)
        {
            SqlConnection miConexion = new SqlConnection(ConexionSQL.cadenaConexion());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "select habilitado from NONAME.Auto where id_auto=" + idautomovil;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = miConexion;


            System.Console.Write(cmd.CommandText);

            miConexion.Open();

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                return reader["habilitado"].ToString();
            }
            return "";
        }

        public static DataTable filtrarAutomoviles(Automovil auto) {
            try
            {
                conectar();

                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT AC.id_auto, A.patente_auto, A.modelo, A.id_marca, M.nombre, A.rodado, A.licencia, U.nombre, U.apellido, AC.id_turno, AC.id_chofer, A.habilitado FROM NONAME.Auto A join NONAME.Auto_Chofer AC on A.id_auto = AC.id_auto, NONAME.Usuario U, NONAME.Marca M WHERE U.id_usuario = AC.id_chofer And M.id_marca = A.id_marca And " + ((auto.idmarca == 0) ? "1=1" : ("A.id_marca ='" + auto.idmarca) + "'") + (String.IsNullOrEmpty(auto.modelo) ? " And 1=1" : (" And A.modelo ='" + auto.modelo + "'")) + (String.IsNullOrEmpty(auto.patente) ? " And 1=1" : (" And A.patente_auto ='" + auto.patente + "'")) + (String.IsNullOrEmpty(auto.nombreChofer) ? " And 1=1" : (" And U.nombre ='" + auto.nombreChofer + "' ")) + (String.IsNullOrEmpty(auto.apellidoChofer) ? " And 1=1" : (" And U.apellido ='" + auto.apellidoChofer + "' "));
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = miConexion;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableAutos = new DataTable();
                dataTableAutos.Load(sqlReader);
                return dataTableAutos;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }

        public static DataTable obtenerTodosLosAutomoviles()
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT AC.id_auto, A.patente_auto, A.modelo, A.id_marca, M.nombre, A.rodado, A.licencia, U.nombre, U.apellido, AC.id_turno, AC.id_chofer, A.habilitado FROM NONAME.Auto A join NONAME.Auto_Chofer AC on A.id_auto = AC.id_auto, NONAME.Usuario U, NONAME.Marca M WHERE U.id_usuario = AC.id_chofer And M.id_marca = A.id_marca";
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = miConexion;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableAutos = new DataTable();
                dataTableAutos.Load(sqlReader);
                return dataTableAutos;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }


        public static string modificarAutomovil(Automovil auto)
        {
                conectar();
                sqlCommand = new SqlCommand("NONAME.sproc_automovil_modificacion");
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
                sqlCommand.Parameters.AddWithValue("@id_auto", auto.idautomovil);

                int response=sqlCommand.ExecuteNonQuery();
                if (response > 0)
                {
                    return "Se modifico correctamente el automovil: " + auto.idautomovil;
                }
                else
                {
                    return "No se pudo realizar la modificacion";
                }
           
        }

        public static int eliminarAutomovil(Automovil auto)
        {
                conectar();
                sqlCommand = new SqlCommand("NONAME.sproc_automovil_baja");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@id_auto", auto.idautomovil);

                int response=sqlCommand.ExecuteNonQuery();

                return response;
                
        }

        public static DataTable obtenerAutomovilDelChofer(int id_chofer, int id_turno)
        {
            try
            {
                conectar();

                sqlCommand = new SqlCommand();

                sqlCommand.CommandText = "SELECT a.id_auto, a.patente_auto FROM NONAME.Auto a join NONAME.Auto_chofer c on c.id_auto = a.id_auto WHERE " + "c.id_chofer ='" + id_chofer + "'" + "And c.id_turno = '" + id_turno+"'";
                sqlCommand.CommandType = CommandType.Text; //Esto es opcional porque de base es un texto
                sqlCommand.Connection = miConexion;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableClientes = new DataTable();
                dataTableClientes.Load(sqlReader);
                return dataTableClientes;

            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }

        public static DataTable obtenerTodasLasMarcas()
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT id_marca, nombre FROM NONAME.Marca";
                sqlCommand.CommandType = CommandType.Text; //opcional
                sqlCommand.Connection = miConexion;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableMarcas = new DataTable();
                dataTableMarcas.Load(sqlReader);
                return dataTableMarcas;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }
    }
}


