using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Objetos
{
    public class Rol
    {
       public string nombre { get; set; }
       public bool estado { get; set; }
       public Dictionary<int, Boolean> diccionarioFunciones { get; set; }

       public Rol() { }
       public Rol(string nom, bool est ,Dictionary<int, Boolean> diccionarioFunc)
       {
           this.nombre = nom;
           this.estado = est;
           this.diccionarioFunciones = diccionarioFunc;
       }
       public Rol(DataGridViewRow datosCliente)
       {
           this.nombre = datosCliente.Cells["nombre"].Value.ToString();
           //ver que onda la funcionalidad
       }

       public Rol(string nom)
       {
           this.nombre = nom;
       }
   }
}