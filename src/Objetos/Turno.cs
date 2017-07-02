using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Objetos
{
    public class Turno
    {
        public int id_turno { get; set; }
        public int hora_inicio { get; set; }
        public int hora_fin { get; set; }
        public string descripcion { get; set; }
        public decimal valor_km { get; set; }
        public decimal precio_base { get; set; }
        public bool habilitado { get; set; }
        
        public Turno() { }

        //Este turno se crea cuando se hace una alta de turno
        public Turno (int horaInicio, int horaFin, string desc, decimal valorKm, decimal precioBase, bool hab) {
            this.hora_inicio = horaInicio;
            this.hora_fin = horaFin;
            this.descripcion = desc;
            this.valor_km = valorKm;
            this.precio_base = precioBase;
            this.habilitado = hab;
        }

        public Turno(int id,int horaInicio, int horaFin, string desc, decimal valorKm, decimal precioBase, bool hab)
        {
            this.id_turno = id;
            this.hora_inicio = horaInicio;
            this.hora_fin = horaFin;
            this.descripcion = desc;
            this.valor_km = valorKm;
            this.precio_base = precioBase;
            this.habilitado = hab;
        }

        public Turno(DataGridViewRow datosTurno)
        {
            this.id_turno = int.Parse(datosTurno.Cells["id_turno"].Value.ToString());
            this.hora_inicio = int.Parse(datosTurno.Cells["hora_inicio"].Value.ToString());
            this.hora_fin = int.Parse(datosTurno.Cells["hora_fin"].Value.ToString());
            this.descripcion = datosTurno.Cells["descripcion"].Value.ToString();
            this.valor_km = decimal.Parse(datosTurno.Cells["valor_km"].Value.ToString());
            this.precio_base = decimal.Parse(datosTurno.Cells["precio_base"].Value.ToString());
            this.habilitado = Convert.ToBoolean(datosTurno.Cells["habilitado"].Value.ToString());
        }

        public Turno(string desc)
        {
            this.descripcion = desc;
        }
    }
}
