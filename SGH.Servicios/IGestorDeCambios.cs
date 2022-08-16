using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.Servicios
{
    /// <summary>
    /// Interface Gestor de Cambios
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGestorDeCambios<T>
    {
        /// <summary>
        /// Audita  insert.
        /// </summary>
        /// <param name="Objeto">The objeto.</param>
        void AuditarInsert(T Objeto);
        /// <summary>
        /// Audita update.
        /// </summary>
        /// <param name="Objeto">The objeto.</param>
        void AuditarUpdate(T Objeto);

    }
}
