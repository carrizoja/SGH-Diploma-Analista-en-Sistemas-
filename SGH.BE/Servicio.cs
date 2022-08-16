using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE
{
    /// <summary>
    /// Clase Entidad de Negocio perteneciente a Servicio
    /// </summary>
    public class Servicio
    {
        private int idServicio;
        private string descripcion;
        private string disponibilidad;
        private int precio;

        public int Precio { get => precio; set => precio = value; }
        public string Disponibilidad { get => disponibilidad; set => disponibilidad = value; }
        public int IdServicio { get => idServicio; set => idServicio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        
        
    }
}
