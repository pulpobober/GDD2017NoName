using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Objetos
{
    public class Rol
    {
       public int id_rol { get; set; }
       public string nombre { get; set; }
       public bool estado { get; set; }
       public DataTable tablaFuncionalidades { get; set; }
       public Rol() { }

    //Este rol se crea cuando voy a crear un rol
       public Rol(string nom, bool est, DataTable funciones)
       {
           this.nombre = nom;
           this.estado = est;
           this.tablaFuncionalidades = funciones;
       }


        //Este rol se crea cuando voy a modificar un rol
       public Rol(int id, string nom, bool est, DataTable funciones)
       {
           this.id_rol = id;
           this.nombre = nom;
           this.estado = est;
           this.tablaFuncionalidades = funciones;
       }
       public Rol(DataGridViewRow datosRol)
       {
           this.nombre = datosRol.Cells["tipo"].Value.ToString();
           this.estado = Convert.ToBoolean(datosRol.Cells["habilitado"].Value.ToString());
           this.id_rol = Int32.Parse(datosRol.Cells["id_rol"].Value.ToString());
       }

       public Rol(string nom)
       {
           this.nombre = nom;
       }
   }
}