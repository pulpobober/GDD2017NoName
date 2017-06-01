using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
        public int idturno { get; set; }
        public string patente { get; set; }
        public string modelo{ get; set; }
        public int idmarca { get; set; }
        public int idchofer{ get; set; }
        public string rodado{ get; set; }
        public string licencia { get; set; }
        public int habilitado{ get; set; }
    }
    }
