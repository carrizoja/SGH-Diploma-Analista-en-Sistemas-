using SGH.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Carrizo.Persistencia;
using System.Configuration;


namespace SGH.DAL
{
    /// <summary>
    /// Mapper de Servicios
    /// </summary>
    public class DALServicios
    {
        /// <summary>
        /// Trae todos los room services.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<BE.Vistas.RoomServiceVista> TraerTodosLosRoomServices()
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                var datosRoomServices = unaConexion.EjecutarTupla<BE.Vistas.RoomServiceVista>("select RS.IdRoomService, RS.Descripcion, RS.Precio, RS.Disponibilidad from RoomService RS inner join Servicio SER on RS.IdServicio = SER.IdServicio where RS.IdServicio = SER.IdServicio order by RS.Descripcion ASC  ", new Dictionary<string, object>());

                unaConexion.ConexionFinalizar();

                return datosRoomServices;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Trae tipos servicios.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<BE.Vistas.TipoServicio> TraerTiposServicios()
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                var datosTipoServicios = unaConexion.EjecutarTupla<BE.Vistas.TipoServicio>("select * from Servicio  ", new Dictionary<string, object>());

                unaConexion.ConexionFinalizar();

                return datosTipoServicios;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Trae servicio seleccionado.
        /// </summary>
        /// <param name="nombre">The nombre.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<BE.Vistas.TipoServicio> TraerServicioSeleccionado(string nombre)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@Nombre", nombre);

                var datosTipoServicios = unaConexion.EjecutarTupla<BE.Vistas.TipoServicio>("select * from Servicio where Nombre=@Nombre", parametros);

                unaConexion.ConexionFinalizar();

                return datosTipoServicios;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }



        /// <summary>
        /// Trae todos los servicios complementarios.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<BE.Vistas.ServicioComplementarioVista> TraerTodosLosServiciosComplementarios()
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                var datosServiciosComplementarios = unaConexion.EjecutarTupla<BE.Vistas.ServicioComplementarioVista>("select SC.IdServicioComplementario, SC.Descripcion, SC.Precio, SC.Disponibilidad, SC.HorasAlquiler from ServicioComplementario SC inner join Servicio SER on SER.IdServicio = SC.IdServicio where SER.IdServicio = SC.IdServicio order by SC.Descripcion ASC  ", new Dictionary<string, object>());

                unaConexion.ConexionFinalizar();

                return datosServiciosComplementarios;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }


        /// <summary>
        /// Alta room service.
        /// </summary>
        /// <param name="roomService">The room service.</param>
        /// <returns></returns>
        public int AltaRoomService(RoomService roomService)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@Descripcion", roomService.Descripcion);
                parametros.Add("@Precio", roomService.Precio);
                parametros.Add("@Disponibilidad", roomService.Disponibilidad);

                parametros.Add("@EsBebida", Convert.ToInt32(roomService.Esbebida));
                parametros.Add("@IdServicio", roomService.IdServicio);


                var roomServicesEnBase = unaConexion.EjecutarTupla<RoomService>("Select * from RoomService", parametros);

                foreach (var roomServiceBase in roomServicesEnBase)
                {
                    if (roomServiceBase.Descripcion == roomService.Descripcion)
                    {
                        return 0;
                    }

                }

                unaConexion.EjecutarSinResultado("insert into RoomService values(@Descripcion, @Precio, @Disponibilidad, @EsBebida, @IdServicio)", parametros);



                unaConexion.TransaccionAceptar();
                unaConexion.ConexionFinalizar();





            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();

            }
            return 1;


        }

        /// <summary>
        /// Alta servicio complementario.
        /// </summary>
        /// <param name="servicioComplementario">The servicio complementario.</param>
        /// <returns></returns>
        public int AltaServicioComplementario(ServicioComplementario servicioComplementario)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@Descripcion", servicioComplementario.Descripcion);
                parametros.Add("@Precio", servicioComplementario.Precio);
                parametros.Add("@Disponibilidad", servicioComplementario.Disponibilidad);
                parametros.Add("@HorasAlquiler", servicioComplementario.HorasAlquiler);
                parametros.Add("@IdServicio", servicioComplementario.IdServicio);



                var serviciosComplementariosEnBase = unaConexion.EjecutarTupla<ServicioComplementario>("Select * from ServicioComplementario", parametros);

                foreach (var servicioComplementarioBase in serviciosComplementariosEnBase)
                {
                    if (servicioComplementarioBase.Descripcion == servicioComplementario.Descripcion)
                    {
                        return 0;
                    }

                }

                unaConexion.EjecutarSinResultado("insert into ServicioComplementario values(@Descripcion, @Precio, @Disponibilidad, @HorasAlquiler, @IdServicio)", parametros);



                unaConexion.TransaccionAceptar();
                unaConexion.ConexionFinalizar();





            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();

            }
            return 1;


        }

        /// <summary>
        /// Modifica room service.
        /// </summary>
        /// <param name="roomService">The room service.</param>
        /// <returns></returns>
        public int ModificarRoomService(RoomService roomService)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@IdRoomService", roomService.IdRoomService);
                parametros.Add("@Descripcion", roomService.Descripcion);
                parametros.Add("@Precio", roomService.Precio);
                parametros.Add("@Disponibilidad", roomService.Disponibilidad);
                parametros.Add("@EsBebida", roomService.Esbebida);


                unaConexion.EjecutarSinResultado("update RoomService set Descripcion=@Descripcion,Precio=@Precio,Disponibilidad=@Disponibilidad,EsBebida=@EsBebida where @IdRoomService=IdRoomService", parametros);



                unaConexion.TransaccionAceptar();
                unaConexion.ConexionFinalizar();

                return 1;



            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();

            }
            return 0;


        }

        /// <summary>
        /// Modifica servicio complementario.
        /// </summary>
        /// <param name="servicioComplementario">The servicio complementario.</param>
        /// <returns></returns>
        public int ModificarServicioComplementario(ServicioComplementario servicioComplementario)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@IdServicioComplementario", servicioComplementario.IdServicioComplementario);
                parametros.Add("@Descripcion", servicioComplementario.Descripcion);
                parametros.Add("@Precio", servicioComplementario.Precio);
                parametros.Add("@Disponibilidad", servicioComplementario.Disponibilidad);
                parametros.Add("@HorasAlquiler", servicioComplementario.HorasAlquiler);


                unaConexion.EjecutarSinResultado("update ServicioComplementario set Descripcion=@Descripcion,Precio=@Precio,Disponibilidad=@Disponibilidad,HorasAlquiler=@HorasAlquiler where @IdServicioComplementario=IdServicioComplementario", parametros);



                unaConexion.TransaccionAceptar();
                unaConexion.ConexionFinalizar();

                return 1;



            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();

            }
            return 0;


        }

        /// <summary>
        /// Borra room service.
        /// </summary>
        /// <param name="idRS">The identifier rs.</param>
        /// <returns></returns>
        public int BorrarRoomService(int idRS)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                
                parametros.Add("@IdRoomService", idRS);
                unaConexion.EjecutarSinResultado("delete from RoomService where IdRoomService=@IdRoomService", parametros);


                unaConexion.TransaccionAceptar();
                unaConexion.ConexionFinalizar();

                return 1;

            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();
                return 0;
            }
        }

        /// <summary>
        /// Borra servicio complementario.
        /// </summary>
        /// <param name="idSC">The identifier sc.</param>
        /// <returns></returns>
        public int BorrarServicioComplementario(int idSC)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();

            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();

                parametros.Add("@IdServicioComplementario", idSC);
                unaConexion.EjecutarSinResultado("delete from ServicioComplementario where IdServicioComplementario=@IdServicioComplementario", parametros);


                unaConexion.TransaccionAceptar();
                unaConexion.ConexionFinalizar();

                return 1;

            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();
                return 0;
            }
        }
    }
}
