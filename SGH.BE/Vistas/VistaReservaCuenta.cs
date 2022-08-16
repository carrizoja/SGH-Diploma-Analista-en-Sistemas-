using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE.Vistas
{
    /// <summary>
    /// Vista de Reserva - Cuenta
    /// </summary>
    public class VistaReservaCuenta
    {
        public int idReserva { get; set; }
        public Guid idCliente { get; set; }

        public int idHabitacion { get; set; }
        
        private int cantidadDias;
        private int precio;

        
        
        
        public int CantidadDias { get => cantidadDias; set => cantidadDias = value; }
        public int Precio { get => precio; set => precio = value; }
        
    }
}
