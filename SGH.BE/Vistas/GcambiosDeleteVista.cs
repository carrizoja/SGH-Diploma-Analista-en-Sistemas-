using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE.Vistas
{
    /// <summary>
    /// Vista perteneciente a la eliminación en gestión de Cambios
    /// </summary>
    public class GcambiosDeleteVista
    {
        public long SYS_CHANGE_VERSION { get; set; }

        public string SYS_CHANGE_OPERATION { get; set; }
    }
}
