using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE.Vistas
{
    /// <summary>
    /// La vista principal de la Reserva
    /// </summary>
    public class ReservaVista
    {
       
        public int idReserva { get; set; }
        public string Numero { get; set; }
        public string Categoria { get; set; }
        public string Tipo { get; set; }
        public DateTime fechaLlegada { get; set; }
        public DateTime fechaSalida { get; set; }
        public int cantidadDias { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string checkIn { get; set; }
    }
}
