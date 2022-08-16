using SGH.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BLL
{
    /// <summary>
    /// Clase Lógica de Negocio perteneciente a Habitación
    /// </summary>
    public class BLLHabitacion
    {
        
        private DAL.DALHabitacion dal = new DAL.DALHabitacion();

        /// <summary>
        /// Registra habitacion.
        /// </summary>
        /// <param name="nuevaHabitacion">The nueva habitacion.</param>
        /// <returns></returns>
        public int RegistrarHabitacion(Habitacion nuevaHabitacion)
        {
            return dal.RegistrarHabitacion(nuevaHabitacion);
        }
        /// <summary>
        /// Trae todas las habitaciones.
        /// </summary>
        /// <returns></returns>
        public List<Habitacion> TraerTodasLasHabitaciones()
        {
            return dal.TraerTodasLasHabitaciones();

        }

        /// <summary>
        /// Trae todas las habitaciones desocupadas.
        /// </summary>
        /// <returns></returns>
        public List<Habitacion> TraerTodasLasHabitacionesDesocupadas()
        {
            return dal.TraerTodasLasHabitacionesDesocupadas();

        }

        /// <summary>
        /// Modifica habitacion.
        /// </summary>
        /// <param name="unaHabitacionModificada">The una habitacion modificada.</param>
        /// <returns></returns>
        public int ModificarHabitacion(Habitacion unaHabitacionModificada)
        {
            return dal.ModificarHabitacion(unaHabitacionModificada);


        }

        /// <summary>
        /// Trae todos los tipos habitacion.
        /// </summary>
        /// <returns></returns>
        public List<TipoHabitacion> TraerTodosLosTiposHabitacion()
        {
            return dal.TraerTodosLosTiposHabitacion();
        }

        /// <summary>
        /// Borra habitacion.
        /// </summary>
        /// <param name="idHab">The identifier hab.</param>
        /// <returns></returns>
        public int BorrarHabitacion(int idHab)
        {
            return dal.BorrarHabitacion(idHab);
        }
        /// <summary>
        /// Obtener ID habitacion.
        /// </summary>
        /// <param name="numeroHab">The numero hab.</param>
        /// <returns></returns>
        public List<Habitacion> ObtenerIDHabitacion(string numeroHab)
        {
            return dal.ObtenerIDHabitacion(numeroHab);
        }

        /// <summary>
        /// Cambia estado habitacion.
        /// </summary>
        /// <param name="nombre">The nombre.</param>
        /// <param name="unaHabitacion">The una habitacion.</param>
        /// <returns></returns>
        public int CambiarEstadoHabitacion(string nombre, Habitacion unaHabitacion)
        {
            return dal.CambiarEstadoHabitacion(nombre, unaHabitacion);
        }

        /// <summary>
        /// Libera habitacion.
        /// </summary>
        /// <param name="idHabitacion">The identifier habitacion.</param>
        /// <returns></returns>
        public int LiberarHabitacion(int idHabitacion)
        {
            return dal.LiberarHabitacion(idHabitacion);
        }

        /// <summary>
        /// Comprueba ocupacion habitacion.
        /// </summary>
        /// <param name="fechaDesde">The fecha desde.</param>
        /// <param name="numeroHab">The numero hab.</param>
        /// <param name="idCliente">The identifier cliente.</param>
        /// <returns></returns>
        public List<SGH.BE.Vistas.ReservaObtenida> ComprobarOcupacionHabitacion(DateTime fechaDesde, string numeroHab, Guid idCliente)
        {
            return dal.ComprobarOcupacionHabitacion(fechaDesde,numeroHab, idCliente);

        }
        /// <summary>
        /// Comprueba ocupacion habitacion modificar.
        /// </summary>
        /// <param name="fechaDesde">The fecha desde.</param>
        /// <param name="numeroHab">The numero hab.</param>
        /// <param name="idCliente">The identifier cliente.</param>
        /// <returns></returns>
        public List<SGH.BE.Vistas.ReservaObtenida> ComprobarOcupacionHabitacionModificar(DateTime fechaDesde, string numeroHab, Guid idCliente)
        {
            return dal.ComprobarOcupacionHabitacionModificar(fechaDesde, numeroHab, idCliente);

        }

    }
}
