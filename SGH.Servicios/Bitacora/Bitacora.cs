using SGH.BE.CompositePermisos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE
{
    /// <summary>
    /// Clase de Entidad de Negocio de Bitácora. Esta es una referencia rapida para el que instancia la clase
    /// </summary>
    [Serializable]
    public class Bitacora
    {
        public Usuario usuario { get; set; }
        public DateTime fecha { get; set; }
        public string descripcion { get; set; }
        public string formulario { get; set; }


    }
}
