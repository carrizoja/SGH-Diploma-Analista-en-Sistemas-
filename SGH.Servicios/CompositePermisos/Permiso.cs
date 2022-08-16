using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE.CompositePermisos
{
    /// <summary>
    /// Interface que corresponde al Permiso
    /// </summary>
    public interface Permiso
    {
        Guid IdPermiso { get; set; }
        String Nombre { get; set; }

        void AgregarComponente(Permiso _componentElement);
        void RemoverComponente(Permiso _componentElement);
        int CantidadHijos();
    }
}
