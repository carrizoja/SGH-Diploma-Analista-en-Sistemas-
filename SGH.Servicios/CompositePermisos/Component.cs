using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE.CompositePermisos
{
    /// <summary>
    /// Clase abstracta de la clase padre del Composite
    /// </summary>
    public abstract class Component
    {
        public Guid IdFamiliaPadre { get; set; }
        public string Descripcion { get; set; }

        public abstract void AgregarComponente(Component _componentElement);
        public abstract void RemoverComponente(Component _componentElement);
        public abstract int CantidadHijos();


    }
}
