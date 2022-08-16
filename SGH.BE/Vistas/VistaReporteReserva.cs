using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE.Vistas
{
    /// <summary>
    /// Vista de un reporte de Reservas
    /// </summary>
    public class VistaReporteReserva
    {
        private string numero;
        private string tipo;
        private string categoria;
        private int total;
        private DateTime fechaLlegada;
        private string nombre;

        public string Numero { get => numero; set => numero = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public int Total{ get => total; set => total = value; }
        public DateTime FechaLlegada { get => fechaLlegada; set => fechaLlegada = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        private string apellido;

    }
}
