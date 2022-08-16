using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE
{
    /// <summary>
    /// Clase de Entidad de Negocio perteneciente a Reserva
    /// </summary>
    public class Reserva
    {
        public int IdReserva { get; set; }

        public Cliente Cliente { get; set; }

        public Habitacion habitacion { get; set; }
        public DateTime FechaLlegada { get; set; }
        public DateTime FechaSalida { get; set; }

        public int CantidadDias { get; set; }

        private String checkIn;
        public string CheckIn { get => checkIn; set => checkIn = value; }
        public bool EsViajeLaboral { get => esViajeLaboral; set => esViajeLaboral = value; }
        public bool ConNinios { get => conNinios; set => conNinios = value; }
        public bool Activa { get => activa; set => activa = value; }

        private bool esViajeLaboral;

        private bool conNinios;
        private bool activa;
        
        

        
        
    }
}
