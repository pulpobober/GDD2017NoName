using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace UberFrba.Objetos
{
    public class Automovil
    {
        public Automovil()
        {
        }
       public Automovil(DataTable turnos , string patente,string modelo,int idmarca,int idchofer,string rodado, string licencia, int habilitado) {
            this.idturno = turnos;
            this.patente = patente;
            this.modelo = modelo;
            this.idmarca = idmarca;
            this.idchofer = idchofer;
            this.rodado = rodado;
            this.licencia = licencia;
            this.habilitado = habilitado;
        }

        public Automovil(int idmarca, string modelo, string patente, string nombre, string apellido) {
           this.idmarca = idmarca;
           this.modelo = modelo;
           this.patente = patente;
           this.nombreChofer = nombre;
           this.apellidoChofer = apellido;
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
           this.idmarca = int.Parse(datosAutomovil.Cells["id_marca"].Value.ToString());
           this.idchofer = int.Parse(datosAutomovil.Cells["id_chofer"].Value.ToString());
           //this.idturno = int.Parse(datosAutomovil.Cells["id_turno"].Value.ToString());
           bool hab = Convert.ToBoolean(datosAutomovil.Cells["habilitado"].Value.ToString());
            if (hab){
                this.habilitado = 1;
            }
            else{
                this.habilitado = 0;
            }

           this.rodado = datosAutomovil.Cells["rodado"].Value.ToString();
           this.licencia = datosAutomovil.Cells["licencia"].Value.ToString();

        }
        public Automovil(int idauto, DataTable idturno, string patente, string modelo, int idmarca, int idchofer, string rodado, string licencia, int habilitado)
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
        public DataTable idturno { get; set; }
        public string patente { get; set; }
        public string modelo{ get; set; }
        public int idmarca { get; set; }
        public int idchofer{ get; set; }
        public string rodado{ get; set; }
        public string licencia { get; set; }
        public int habilitado{ get; set; }
        public int idautomovil { get; set; }

        //Solo se usan para filtar
        public string nombreChofer { get; set; }
        public string apellidoChofer { get; set; }

    }
    }
