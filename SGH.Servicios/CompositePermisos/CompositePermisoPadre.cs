using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE.CompositePermisos
{
    /// <summary>
    /// Clase Permiso - Padre del Composite
    /// </summary>
    /// <seealso cref="SGH.BE.CompositePermisos.Component" />
    public class CompositePermisoPadre : Component
    {
        
        public List<Component> accesos = new List<Component>();

        /// <summary>
        /// Agrega componente.
        /// </summary>
        /// <param name="_componentElement">The component element.</param>
        public override void AgregarComponente(Component _componentElement)
        {
            accesos.Add(_componentElement);
        }
        /// <summary>
        /// Cantidad hijos.
        /// </summary>
        /// <returns></returns>
        public override int CantidadHijos()
        {
            return accesos.Count();
        }
        /// <summary>
        /// Remover componente.
        /// </summary>
        /// <param name="_componentElement">The component element.</param>
        public override void RemoverComponente(Component _componentElement)
        {
            accesos.Remove(_componentElement);
        }
    }
}
