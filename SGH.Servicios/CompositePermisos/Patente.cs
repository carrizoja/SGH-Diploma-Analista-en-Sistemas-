using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE.CompositePermisos
{
    /// <summary>
    /// Clase Patente del Composite
    /// </summary>
    /// <seealso cref="SGH.BE.CompositePermisos.Permiso" />
    public class Patente : Permiso

    {
        public Guid IdPermiso { get ; set ; }
        public string Nombre { get ; set ; }

        /// <summary>
        /// Agrega componente.
        /// </summary>
        /// <param name="_componentElement">The component element.</param>
        /// <exception cref="Exception">No se puede agregar permiso</exception>
        public void AgregarComponente(Permiso _componentElement)
        {
            throw new Exception("No se puede agregar permiso");
        }
        /// <summary>
        /// Cantidad hijos.
        /// </summary>
        /// <returns></returns>
        public int CantidadHijos()
        {
            return 0;
        }
        /// <summary>
        /// Remueve el componente.
        /// </summary>
        /// <param name="_componentElement">The component element.</param>
        /// <exception cref="Exception">No se puede remover permiso</exception>
        public void RemoverComponente(Permiso _componentElement)
        {
            throw new Exception(" No se puede remover permiso");
        }
    }
}
