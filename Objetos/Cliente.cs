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
       public Cliente(string nom, string ape, int Dni) {
           this.nombre = nom;
           this.apellido = ape;
           this.dni = Dni;
       }

       public Cliente(DataGridViewRow datosCliente)
       {
           this.nombre = datosCliente.Cells["nombre"].Value.ToString();
           this.apellido = datosCliente.Cells["apellido"].Value.ToString();
           this.dni = Int32.Parse(datosCliente.Cells["id_usuario_dni"].Value.ToString());
           this.mail = datosCliente.Cells["mail"].Value.ToString(); ;
           this.telefono = Int32.Parse(datosCliente.Cells["telefono"].Value.ToString());
           this.direccion = datosCliente.Cells["direccion"].Value.ToString();
           this.localidad = datosCliente.Cells["localidad"].Value.ToString();
           this.codPostal = Int32.Parse(datosCliente.Cells["codigo_postal"].Value.ToString());
           this.fechaNacimiento = DateTime.ParseExact(datosCliente.Cells["fecha_nacimiento"].Value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
       }
       public Cliente(string nom, string ape,int Dni,string email,int tel,string dir,string Localidad,int codPost,DateTime fechaNac) {
            this.nombre = nom;
            this.apellido = ape;
            this.dni = Dni;
            this.mail = email;
            this.telefono = tel;
            this.direccion = dir;
            this.localidad = Localidad;
            this.codPostal = codPost;
            this.fechaNacimiento = fechaNac;
        }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public string mail { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }
        public string localidad { get; set; }
        public int codPostal { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public bool habilitado { get; set; }
        public int intentos_fallidos { get; set; }
 
   }
}
