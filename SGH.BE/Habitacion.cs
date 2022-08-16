using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE
{
    /// <summary>
    /// Clase de Entidad de Negocio perteneciente a Habitación
    /// </summary>
    public class Habitacion
    {
        public int IdHabitacion { get; set; }
        public string Numero { get; set; }

        public string Tipo { get; set; }
       
        public string Categoria { get; set; }
        public int Precio { get; set; }
        public string EstadoHabitacion { get; set; }
    }
}
