using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Objetos
{
    class Automovil
    {
       public Automovil(string turno, string patente,string modelo,string marca,string chofer) {
            this.turno = turno;
            this.patente = patente;
            this.modelo = modelo;
            this.marca = marca;
            this.chofer = chofer;
        }
        public string turno { get; set; }
        public string patente { get; set; }
        public string modelo{ get; set; }
        public string marca { get; set; }
        public string chofer{ get; set; }
    }
    }
