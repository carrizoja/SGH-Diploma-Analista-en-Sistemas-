using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGH.BE.MultiIdioma;

namespace SGH.Servicios
{
    /// <summary>
    /// Clase que sirve para el cambio de Idioma
    /// </summary>
    public class Idioma
    {
        static readonly Idioma INSTANCIA = new Idioma();
        /// <summary>
        /// Obtiene idioma actual.
        /// </summary>
        /// <value>
        /// The idioma actual.
        /// </value>
        public static Idioma IDIOMA_ACTUAL
        {
            get { return INSTANCIA; }
        }

        private BE.MultiIdioma.Idioma _Idioma;
        /// <summary>
        /// Establece  idioma actual.
        /// </summary>
        /// <param name="unIdioma">The un idioma.</param>
        public void EstablecerIdiomaActual(BE.MultiIdioma.Idioma unIdioma)
        {
            this._Idioma = unIdioma;
        }
        /// <summary>
        /// Obtiene idioma actual.
        /// </summary>
        /// <returns></returns>
        public BE.MultiIdioma.Idioma ObtenerIdiomaActual()
        {
            return this._Idioma;
        }
    }
}
