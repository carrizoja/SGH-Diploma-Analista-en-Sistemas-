using SGH.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BLL
{
    /// <summary>
    /// Clase de Lógica de Negocio perteneciente a la Categoría de Habitación
    /// </summary>
    public class BLLCategoriaHabitacion
    {
        private DAL.DALCategoriaHabitacion dal = new DAL.DALCategoriaHabitacion();

        /// <summary>
        /// Registra  categoria habitacion.
        /// </summary>
        /// <param name="nuevaCategoriaHabitacion">The nueva categoria habitacion.</param>
        /// <returns></returns>
        public int RegistrarCategoriaHabitacion(CategoriaHabitacion nuevaCategoriaHabitacion)
        {
            return dal.RegistrarCategoriaHabitacion(nuevaCategoriaHabitacion);
        }

        /// <summary>
        /// Trae todas las categoriashabitacion.
        /// </summary>
        /// <returns></returns>
        public List<CategoriaHabitacion> TraerTodasCategoriashabitacion()
        {
            return dal.TraerTodosLasCategoriaHabitacion();

        }


        /// <summary>
        /// Modifica categoria habitacion.
        /// </summary>
        /// <param name="unaCategoriaHabitacionModificada">The una categoria habitacion modificada.</param>
        /// <param name="CodCategoriaHabitacion">The cod categoria habitacion.</param>
        /// <returns></returns>
        public int ModificarCategoriaHabitacion(CategoriaHabitacion unaCategoriaHabitacionModificada, String CodCategoriaHabitacion)
        {
            return dal.ModificarCategoriaHabitacion(unaCategoriaHabitacionModificada, CodCategoriaHabitacion);

        
        }

        /// <summary>
        /// Borra categoria habitacion.
        /// </summary>
        /// <param name="CodCategoriaHabitacion">The cod categoria habitacion.</param>
        /// <returns></returns>
        public int BorrarCategoriaHabitacion(String CodCategoriaHabitacion)
        {
            return dal.BorrarCategoriaHabitacion(CodCategoriaHabitacion);
        }

        /// <summary>
        /// Traer categorias habitación
        /// </summary>
        /// <param name="catHab">The cat hab.</param>
        /// <returns></returns>
        public List<CategoriaHabitacion> TraerCatHab(string catHab)
        {
            return dal.TraerCategoriaHab(catHab);
        }
    }
}
