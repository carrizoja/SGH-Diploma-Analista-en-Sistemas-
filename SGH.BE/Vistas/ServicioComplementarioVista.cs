using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE.Vistas
{
    /// <summary>
    /// Vista de un servicio Complementario
    /// </summary>
    public class ServicioComplementarioVista
    {
        private int idServicioComplementario;
        private string descripcion;
        private int precio;
        private string disponibilidad;
        private int horasAlquiler;

        public int IdServicioComplementario { get => idServicioComplementario; set => idServicioComplementario = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Disponibilidad { get => disponibilidad; set => disponibilidad = value; }
        public int HorasAlquiler { get => horasAlquiler; set => horasAlquiler = value; }
    }
}
