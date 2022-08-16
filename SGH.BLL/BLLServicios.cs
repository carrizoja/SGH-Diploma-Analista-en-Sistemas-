using SGH.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BLL
{
    /// <summary>
    /// Clase Lógica de Negocio perteneciente a los servicios
    /// </summary>
    public class BLLServicios
     {
        private DAL.DALServicios serviciosDAL = new DAL.DALServicios();

        /// <summary>
        /// Traer todos los room services.
        /// </summary>
        /// <returns></returns>
        public List<BE.Vistas.RoomServiceVista> TraerTodosLosRoomServices()
        {
            return serviciosDAL.TraerTodosLosRoomServices();

        }
        /// <summary>
        /// Trae tipos servicios.
        /// </summary>
        /// <returns></returns>
        public List<BE.Vistas.TipoServicio> TraerTiposServicios()
        {
            return serviciosDAL.TraerTiposServicios();

        }
        /// <summary>
        /// Trae servicio seleccionado.
        /// </summary>
        /// <param name="nombre">The nombre.</param>
        /// <returns></returns>
        public List<BE.Vistas.TipoServicio> TraerServicioSeleccionado(string nombre)
        {
            return serviciosDAL.TraerServicioSeleccionado(nombre);

        }


        /// <summary>
        /// Trae todos los servicios complementarios.
        /// </summary>
        /// <returns></returns>
        public List<BE.Vistas.ServicioComplementarioVista> TraerTodosLosServiciosComplementarios()
        {
            return serviciosDAL.TraerTodosLosServiciosComplementarios();

        }

        /// <summary>
        /// Alta room service.
        /// </summary>
        /// <param name="roomService">The room service.</param>
        /// <returns></returns>
        public int AltaRoomService(RoomService roomService)
        {
            return serviciosDAL.AltaRoomService(roomService);
        }

        /// <summary>
        /// Alta servicio complementario.
        /// </summary>
        /// <param name="servicioComplementario">The servicio complementario.</param>
        /// <returns></returns>
        public int AltaServicioComplementario(ServicioComplementario servicioComplementario)
        {
            return serviciosDAL.AltaServicioComplementario(servicioComplementario);
        }

        /// <summary>
        /// Modifica room service.
        /// </summary>
        /// <param name="roomService">The room service.</param>
        /// <returns></returns>
        public int ModificarRoomService(RoomService roomService)
        {
            return serviciosDAL.ModificarRoomService(roomService);


        }

        /// <summary>
        /// Modifica servicio complementario.
        /// </summary>
        /// <param name="servicioComplementario">The servicio complementario.</param>
        /// <returns></returns>
        public int ModificarServicioComplementario(ServicioComplementario servicioComplementario)
        {
            return serviciosDAL.ModificarServicioComplementario(servicioComplementario);


        }

        /// <summary>
        /// Borra room service.
        /// </summary>
        /// <param name="idRS">The identifier rs.</param>
        /// <returns></returns>
        public int BorrarRoomService(int idRS)
        {
            return serviciosDAL.BorrarRoomService(idRS);
        }

        /// <summary>
        /// Borra servicio complementario.
        /// </summary>
        /// <param name="idSC">The identifier sc.</param>
        /// <returns></returns>
        public int BorrarServicioComplementario(int idSC)
        {
            return serviciosDAL.BorrarServicioComplementario(idSC);
        }



    }

   
}
