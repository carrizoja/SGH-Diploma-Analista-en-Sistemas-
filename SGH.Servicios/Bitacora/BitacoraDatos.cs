using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE
{

    /// <summary>Clase de Entidad de Negocio de bitácora a Datos</summary>
    public class BitacoraDatos
    {
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Formulario { get; set; }

    }
}
