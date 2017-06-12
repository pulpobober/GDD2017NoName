using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Objetos
{
   public class Chofer
    {
    public Chofer() { }

       //Este Chofer se crea cuando se quiere buscar y filtrar
       public Chofer(string nom, string ape, int Dni) {
           this.nombre = nom;
           this.apellido = ape;
           this.dni = Dni;
       }

       public Chofer(int idChofer)
       {
           this.id_Chofer = idChofer;
       }

       //Este Chofer se crea cuando toco una celda en la tabla de Chofers
       public Chofer(DataGridViewRow datosChofer)
       {
           this.id_Chofer = Int32.Parse(datosChofer.Cells["id_usuario"].Value.ToString());
           this.nombre = datosChofer.Cells["nombre"].Value.ToString();
           this.apellido = datosChofer.Cells["apellido"].Value.ToString();
           this.dni = Int32.Parse(datosChofer.Cells["usuario_dni"].Value.ToString());
           this.mail = datosChofer.Cells["mail"].Value.ToString(); ;
           this.telefono = Int32.Parse(datosChofer.Cells["telefono"].Value.ToString());
           this.direccion = datosChofer.Cells["direccion"].Value.ToString();
           this.fechaNacimiento = Convert.ToDateTime(datosChofer.Cells["fecha_nacimiento"].Value.ToString());
       }

       //Este Chofer se crea cuando voy a modificar el Chofer
       public Chofer(int idChofer,string nom, string ape, int Dni, string email, int tel, string dir, DateTime fechaNac)
       {
           this.id_Chofer = idChofer;
           this.nombre = nom;
           this.apellido = ape;
           this.dni = Dni;
           this.mail = email;
           this.telefono = tel;
           this.direccion = dir;
           this.fechaNacimiento = fechaNac;
       }

       //Este Chofer se crea cuando se de alta un usuario
       public Chofer(string nom, string ape,int Dni,string email,int tel,string dir,DateTime fechaNac) {
            this.nombre = nom;
            this.apellido = ape;
            this.dni = Dni;
            this.mail = email;
            this.telefono = tel;
            this.direccion = dir;
            this.fechaNacimiento = fechaNac;
        }

        public int id_Chofer { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public string mail { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }
        public DateTime fechaNacimiento { get; set; }
   }
}
