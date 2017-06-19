using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UberFrba.Objetos
{
    public class Automovil
    {
       public Automovil(int idturno, string patente,string modelo,int idmarca,int idchofer,string rodado, string licencia, int habilitado) {
            this.idturno = idturno;
            this.patente = patente;
            this.modelo = modelo;
            this.idmarca = idmarca;
            this.idchofer = idchofer;
            this.rodado = rodado;
            this.licencia = licencia;
            this.habilitado = habilitado;
        }

        public Automovil(int idmarca=0, string modelo="", string patente="", int idchofer=0) {
           this.idmarca = idmarca;
           this.modelo = modelo;
           this.patente = patente;
           this.idchofer = idchofer;
       }
        public Automovil(int idauto)
        {
            this.idautomovil = idauto;
            this.modelo = modelo;
            this.patente = patente;
            this.idchofer = idchofer;
        }

        public Automovil(DataGridViewRow datosAutomovil)
        {
           this.idautomovil = Int32.Parse(datosAutomovil.Cells["id_auto"].Value.ToString());
           this.patente = datosAutomovil.Cells["patente_auto"].Value.ToString();
           this.modelo = datosAutomovil.Cells["modelo"].Value.ToString();
           this.marca = datosAutomovil.Cells["marca"].Value.ToString();
           this.chofer = datosAutomovil.Cells["chofer"].Value.ToString();
        }
        public Automovil(int idauto,int idturno, string patente, string modelo, int idmarca, int idchofer, string rodado, string licencia, int habilitado)
        {
            this.idturno = idturno;
            this.patente = patente;
            this.modelo = modelo;
            this.idmarca = idmarca;
            this.idchofer = idchofer;
            this.rodado = rodado;
            this.licencia = licencia;
            this.habilitado = habilitado;
            this.idautomovil = idauto;
        }
        public int idturno { get; set; }
        public string patente { get; set; }
        public string marca { get; set; }
        public string chofer { get; set; }
        public string modelo{ get; set; }
        public int idmarca { get; set; }
        public int idchofer{ get; set; }
        public string rodado{ get; set; }
        public string licencia { get; set; }
        public int habilitado{ get; set; }
        public int idautomovil { get; set; }
    }
    }
