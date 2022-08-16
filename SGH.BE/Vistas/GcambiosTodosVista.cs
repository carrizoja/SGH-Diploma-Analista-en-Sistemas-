using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE.Vistas
{
    /// <summary>
    /// Vista que muestra todos los resultados en Gestión de Cambios
    /// </summary>
    public class GcambiosTodosVista
    {
        public long SYS_CHANGE_VERSION { get; set; }
        
        public string SYS_CHANGE_OPERATION { get; set; }
        public Guid idCliente { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Dni { get; set; }

        public int Edad { get; set; }

        public string Email { get; set; }

        public int Telefono { get; set; }

    }
}
