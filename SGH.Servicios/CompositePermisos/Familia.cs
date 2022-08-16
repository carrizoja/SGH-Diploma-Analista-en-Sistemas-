using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE.CompositePermisos
{
    /// <summary>
    /// Clase Familia del Composite
    /// </summary>
    /// <seealso cref="SGH.BE.CompositePermisos.Permiso" />
    public class Familia : Permiso
    {
        public List<Permiso> accesos = new List<Permiso>();

        public Guid IdPermiso { get ; set ; }
        public string Nombre { get ; set ; }

        /// <summary>
        /// Agregar componente.
        /// </summary>
        /// <param name="_componentElement">The component element.</param>
        public void AgregarComponente(Permiso _componentElement)
        {
            accesos.Add(_componentElement);
        }
        /// <summary>
        /// Cantidad hijos.
        /// </summary>
        /// <returns></returns>
        public int CantidadHijos()
        {
            return accesos.Count();
        }
        /// <summary>
        /// Remover componente.
        /// </summary>
        /// <param name="_componentElement">The component element.</param>
        public void RemoverComponente(Permiso _componentElement)
        {
            accesos.Remove(_componentElement);
        }
    }
}
