using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGH.DAL;
using SGH.BE.Vistas;
using SGH.Servicios;

namespace SGH.BLL
{
    /// <summary>
    /// Clase Lógica de Negocio perteneciente a la Gestión de Cambios
    /// </summary>
    public class BLLGestionCambios
    {
        DALGestionCambios DALGestionCambios = new DALGestionCambios();

        /// <summary>
        /// Trae todo gestion cambios.
        /// </summary>
        /// <returns></returns>
        public List<GcambiosTodosVista> TraerTodoGestionCambios()
        {
            return DALGestionCambios.TraerTodoGestionCambios();
        }
        /// <summary>
        /// Trae todo gestion cambios delete.
        /// </summary>
        /// <returns></returns>
        public List<GcambiosDeleteVista> TraerTodoGestionCambiosDelete()
        {
            return DALGestionCambios.TraerTodoGestionCambiosDelete();
        }

    }
}
