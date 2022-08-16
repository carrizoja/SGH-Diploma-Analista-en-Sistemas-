using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE
{
    /// <summary>
    /// Clase Entidad de Negocio para Traducción
    /// </summary>
    public class Traduccion
    {
        public int IdIdioma { get; set; }
        public Guid IdPalabra { get; set; }
        public string Descripcion { get; set; }


    }
}
