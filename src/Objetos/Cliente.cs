using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Objetos
{
   public class Cliente
    {
       public Cliente() { }

       //Este cliente se crea cuando se quiere buscar y filtrar
       public Cliente(string nom, string ape, int Dni) {
           this.nombre = nom;
           this.apellido = ape;
           this.dni = Dni;
       }

       public Cliente(int idCliente)
       {
           this.id_cliente = idCliente;
       }

       //Este cliente se crea cuando toco una celda en la tabla de clientes
       public Cliente(DataGridViewRow datosCliente)
       {
           this.id_cliente = Int32.Parse(datosCliente.Cells["id_usuario"].Value.ToString());
           this.nombre = datosCliente.Cells["nombre"].Value.ToString();
           this.apellido = datosCliente.Cells["apellido"].Value.ToString();
           this.dni = Int32.Parse(datosCliente.Cells["usuario_dni"].Value.ToString());
           this.mail = datosCliente.Cells["mail"].Value.ToString(); ;
           this.telefono = Int32.Parse(datosCliente.Cells["telefono"].Value.ToString());
           this.direccion = datosCliente.Cells["direccion"].Value.ToString();
           this.codPostal = datosCliente.Cells["codigo_postal"].Value.ToString();
           this.fechaNacimiento = Convert.ToDateTime(datosCliente.Cells["fecha_nacimiento"].Value.ToString());
           this.habilitado = Convert.ToBoolean(datosCliente.Cells["habilitado"].Value.ToString());
       }

       //Este cliente se crea cuando voy a modificar el cliente
       public Cliente(int idCliente,string nom, string ape, int Dni, string email, int tel, string dir, string codPost, DateTime fechaNac, bool hab)
       {
           this.id_cliente = idCliente;
           this.nombre = nom;
           this.apellido = ape;
           this.dni = Dni;
           this.mail = email;
           this.telefono = tel;
           this.direccion = dir;
           this.codPostal = codPost;
           this.fechaNacimiento = fechaNac;
           this.habilitado = hab;
       }

       //Este cliente se crea cuando se de alta un usuario
       public Cliente(string nom, string ape,int Dni,string email,int tel,string dir,string codPost,DateTime fechaNac) {
            this.nombre = nom;
            this.apellido = ape;
            this.dni = Dni;
            this.mail = email;
            this.telefono = tel;
            this.direccion = dir;
            this.codPostal = codPost;
            this.fechaNacimiento = fechaNac;
        }

        public int id_cliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public string mail { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }
        public string codPostal { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public bool habilitado { get; set; }

   }
}
