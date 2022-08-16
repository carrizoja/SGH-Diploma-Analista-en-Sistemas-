using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE.CompositePermisos
{
    /// <summary>
    /// Clase Leaf del permiso Hijo
    /// </summary>
    /// <seealso cref="SGH.BE.CompositePermisos.Component" />
    public class LeafPermisoHijo : Component
    {
        /// <summary>
        /// Agregar componente.
        /// </summary>
        /// <param name="_componentElement">The component element.</param>
        /// <exception cref="Exception">No se puede agregar permiso</exception>
        public override void AgregarComponente(Component _componentElement)
        {
            throw new Exception("No se puede agregar permiso");
        }
        /// <summary>
        /// Cantidad hijos.
        /// </summary>
        /// <returns></returns>
        public override int CantidadHijos()
        {
            return 0;
        }
        /// <summary>
        /// Remover componente.
        /// </summary>
        /// <param name="_componentElement">The component element.</param>
        /// <exception cref="Exception">No se puede remover permiso</exception>
        public override void RemoverComponente(Component _componentElement)
        {
            throw new Exception("No se puede remover permiso");
        }
    }
}
