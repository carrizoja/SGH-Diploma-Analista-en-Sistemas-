using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE.Vistas
{
    /// <summary>
    /// Vista de un tipo de Servicio
    /// </summary>
    public class TipoServicio
    {
        private int idServicio;
        private string nombre;

        public int IdServicio { get => idServicio; set => idServicio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
