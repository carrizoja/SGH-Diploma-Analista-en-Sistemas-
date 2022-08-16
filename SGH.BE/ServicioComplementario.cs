using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE
{
    /// <summary>
    /// Clase de Entidad de Negocio perteneciente a Servicio
    /// </summary>
    /// <seealso cref="SGH.BE.Servicio" />
    public class ServicioComplementario: Servicio
    {
        private int idServicioComplementario;
        private int horasAlquiler;

        public int IdServicioComplementario { get => idServicioComplementario; set => idServicioComplementario = value; }
        public int HorasAlquiler { get => horasAlquiler; set => horasAlquiler = value; }
    }
}
