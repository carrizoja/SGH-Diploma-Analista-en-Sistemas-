using SGH.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BLL
{
    /// <summary>
    /// Clase Lógica de Negocio perteneciente al Tipo de Habitación
    /// </summary>
    public class BLLTipoHabitacion
    {
        private DAL.DALTipoHabitacion dal = new DAL.DALTipoHabitacion();

        /// <summary>
        /// Registra tipo habitacion.
        /// </summary>
        /// <param name="nuevoTipoHabitacion">The nuevo tipo habitacion.</param>
        /// <returns></returns>
        public int RegistrarTipoHabitacion(TipoHabitacion nuevoTipoHabitacion)
        {
            return dal.RegistrarTipoHabitacion(nuevoTipoHabitacion);
        }
        /// <summary>
        /// Trae todos tiposhabitacion.
        /// </summary>
        /// <returns></returns>
        public List<TipoHabitacion> TraerTodosTiposhabitacion()
        {
            return dal.TraerTodosLosTipoHabitacion();

        }

        /// <summary>
        /// Modifica tipo habitacion.
        /// </summary>
        /// <param name="unTipoHabitacionModificado">The un tipo habitacion modificado.</param>
        /// <param name="CodTipoHabitacion">The cod tipo habitacion.</param>
        /// <returns></returns>
        public int ModificarTipoHabitacion(TipoHabitacion unTipoHabitacionModificado, String CodTipoHabitacion)
        {
            return dal.ModificarTipoHabitacion(unTipoHabitacionModificado, CodTipoHabitacion);


        }

        /// <summary>
        /// Borra tipo habitacion.
        /// </summary>
        /// <param name="CodTipoHabitacion">The cod tipo habitacion.</param>
        /// <returns></returns>
        public int BorrarTipoHabitacion(String CodTipoHabitacion)
        {
            return dal.BorrarTipoHabitacion(CodTipoHabitacion);
        }

        /// <summary>
        /// Trae tipo habitación
        /// </summary>
        /// <param name="TipoHab">The tipo hab.</param>
        /// <returns></returns>
        public List<TipoHabitacion> TraerTipoHab(string TipoHab)
        {
            return dal.TraerTipoHab(TipoHab);
        }
    }
}
