using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGH.BE;
using SGH.BE.Vistas;

namespace SGH.BLL
{
    /// <summary>
    /// Clase Lógica de Negocio perteneciente a Reserva
    /// </summary>
    public class BLLReserva
    {
        private DAL.DALReserva dal = new DAL.DALReserva();

        /// <summary>
        /// Registra reserva.
        /// </summary>
        /// <param name="nuevaReserva">The nueva reserva.</param>
        /// <returns></returns>
        public int RegistrarReserva(Reserva nuevaReserva)
        {
            return dal.RegistrarReserva(nuevaReserva);
        }


        /// <summary>
        /// Traer todas las reservas.
        /// </summary>
        /// <returns></returns>
        public List<ReservaVista> TraerTodasLasReservas()
        {
            return dal.TraerTodasLasReservas();
        }

        /// <summary>
        /// Trae todos los reportes reservas.
        /// </summary>
        /// <returns></returns>
        public List<SGH.BE.Vistas.VistaReporteReserva> TraerTodosLosReportesReservas()
        {
            return dal.TraerTodosLosReportesReservas();
        }

        /// <summary>
        /// Trae todos los reportes reservas.
        /// </summary>
        /// <param name="tipoHabitacion">The tipo habitacion.</param>
        /// <param name="categoriaHabitacion">The categoria habitacion.</param>
        /// <param name="desde">The desde.</param>
        /// <param name="hasta">The hasta.</param>
        /// <returns></returns>
        public List<SGH.BE.Vistas.VistaReporteReserva> TraerTodosLosReportesReservas(TipoHabitacion tipoHabitacion, CategoriaHabitacion categoriaHabitacion, DateTime desde, DateTime hasta)
        {
            return dal.TraerTodosLosReportesReservas(tipoHabitacion,categoriaHabitacion,desde,hasta);
        }
        /// <summary>
        /// Traer todos los reportes reservas.
        /// </summary>
        /// <param name="tipoHabitacion">The tipo habitacion.</param>
        /// <returns></returns>
        public List<SGH.BE.Vistas.VistaReporteReserva> TraerTodosLosReportesReservas(TipoHabitacion tipoHabitacion)
        {
            return dal.TraerTodosLosReportesReservas(tipoHabitacion);
        }

        /// <summary>
        /// Trae todos los reportes reservas.
        /// </summary>
        /// <param name="categoriaHabitacion">The categoria habitacion.</param>
        /// <returns></returns>
        public List<SGH.BE.Vistas.VistaReporteReserva> TraerTodosLosReportesReservas(CategoriaHabitacion categoriaHabitacion)
        {
            return dal.TraerTodosLosReportesReservas(categoriaHabitacion);
        }

        /// <summary>
        /// Trae todos los reportes reservas.
        /// </summary>
        /// <param name="desde">The desde.</param>
        /// <param name="hasta">The hasta.</param>
        /// <returns></returns>
        public List<SGH.BE.Vistas.VistaReporteReserva> TraerTodosLosReportesReservas(DateTime desde, DateTime hasta)
        {
            return dal.TraerTodosLosReportesReservas(desde, hasta);
        }

        /// <summary>
        /// Busca reserva por habitacion.
        /// </summary>
        /// <param name="numero">The numero.</param>
        /// <returns></returns>
        public List<SGH.BE.Vistas.ReservaObtenida> BuscarReservaPorHabitacion(string numero)
        {
            return dal.BuscarReservaPorHabitacion(numero);
        }

        /// <summary>
        /// Modifica reserva.
        /// </summary>
        /// <param name="idReserva">The identifier reserva.</param>
        /// <param name="reserva">The reserva.</param>
        /// <returns></returns>
        public int ModificarReserva(int idReserva, Reserva reserva)
        {
            return dal.ModificarReserva(idReserva, reserva);
        }

        /// <summary>
        /// Cambia estado reserva.
        /// </summary>
        /// <param name="cuenta">The cuenta.</param>
        /// <returns></returns>
        public int CambiarEstadoReserva(Cuenta cuenta)
        {
            return dal.CambiarEstadoReserva(cuenta);
        }

        /// <summary>
        /// Borra reserva.
        /// </summary>
        /// <param name="idReserva">The identifier reserva.</param>
        /// <returns></returns>
        public int BorrarReserva(int idReserva)
        {
            return dal.BorrarReserva(idReserva);
        }

        /// <summary>
        /// Realiza check in.
        /// </summary>
        /// <param name="idReserva">The identifier reserva.</param>
        /// <param name="unaReserva">The una reserva.</param>
        /// <returns></returns>
        public int RealizarCheckIn(int idReserva, Reserva unaReserva)
        {
            return dal.RealizarCheckIn(idReserva, unaReserva);
        }

        /// <summary>
        /// Obtiene reserva.
        /// </summary>
        /// <param name="nroReserva">The nro reserva.</param>
        /// <returns></returns>
        public List<SGH.BE.Vistas.VistaReservaCuenta> ObtenerReserva(int nroReserva)
        {
            return dal.ObtenerReserva(nroReserva);
        }
    }
}
