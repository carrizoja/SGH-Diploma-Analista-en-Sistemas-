using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE.Vistas
{
    /// <summary>
    /// Vista que muestra una reserva Obtenida
    /// </summary>
    public class ReservaObtenida
    {
        public int idReserva { get; set; }
        public Guid idCliente { get; set; }

        public int idHabitacion { get; set; }

        
    }
}
