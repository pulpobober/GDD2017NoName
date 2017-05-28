using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
       public Cliente(string nom, string ape,int Dni,string email,int tel,string dir,int Piso,string Depto,string Localidad,int codPost,DateTime fechaNac) {
            this.nombre = nom;
            this.apellido = ape;
            this.dni = Dni;
            this.mail = email;
            this.telefono = tel;
            this.piso = Piso;
            this.depto = Depto;
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
        public int piso { get; set; }
        public string depto { get; set; }
        public string localidad { get; set; }
        public int codPostal { get; set; }
        public DateTime fechaNacimiento { get; set; }
    }
}
