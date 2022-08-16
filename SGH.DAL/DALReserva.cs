using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGH.BE;
using System.Security.Cryptography;
using SGH.Servicios;
using Framework.Carrizo.Encriptadores;
using Framework.Carrizo.Persistencia;
using SGH.BE.Vistas;
using System.Configuration;


namespace SGH.DAL
{
    /// <summary>
    /// Mapper perteneciente a Reserva
    /// </summary>
    public class DALReserva
    {

        /// <summary>
        /// Registra reserva.
        /// </summary>
        /// <param name="nuevaReserva">The nueva reserva.</param>
        /// <returns></returns>
        public int RegistrarReserva(Reserva nuevaReserva)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            //string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@idCliente", nuevaReserva.Cliente.idCliente);
                parametros.Add("@idHabitacion", nuevaReserva.habitacion.IdHabitacion);
                parametros.Add("@fechaLlegada", nuevaReserva.FechaLlegada);
                parametros.Add("@fechaSalida", nuevaReserva.FechaSalida);
                parametros.Add("@cantidadDias", nuevaReserva.CantidadDias);
                parametros.Add("@checkIn", nuevaReserva.CheckIn);
                parametros.Add("@EsViajeLaboral", nuevaReserva.EsViajeLaboral);
                parametros.Add("@ConNinios", nuevaReserva.ConNinios);
                parametros.Add("@Activa", nuevaReserva.Activa);

                unaConexion.EjecutarSinResultado("insert into Reserva values(@idCliente, @idHabitacion, @fechaLlegada, @fechaSalida, @cantidadDias,@checkIn,@EsViajeLaboral,@ConNinios,@Activa)", parametros);



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
        /// Trae todas las reservas.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<ReservaVista> TraerTodasLasReservas()
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            //string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                var datosReserva = unaConexion.EjecutarTupla<ReservaVista>("select re.idReserva, hab.Numero, catHab.Categoria, tipoHab.Tipo, re.fechaLlegada, re.fechaSalida, re.cantidadDias, cli.Nombre, cli.Apellido, re.checkIn from reserva re inner join cliente cli on re.idCliente = cli.idCliente inner join Habitacion hab on re.idHabitacion = hab.IdHabitacion inner join TipoHabitacion tipoHab on hab.CodTipoHabitacion = tipoHab.CodTipoHabitacion inner join CategoriaHabitacion catHab on hab.CodCategoriaHabitacion = catHab.CodCategoriaHabitacion where re.checkIn = 'NO' ", new Dictionary<string, object>());

                unaConexion.ConexionFinalizar();

                return datosReserva;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Trae todos los reportes reservas.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<VistaReporteReserva> TraerTodosLosReportesReservas()
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            //string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                var datosReserva = unaConexion.EjecutarTupla<VistaReporteReserva>("select hab.Numero, tipoHab.Tipo, catHab.Categoria, cu.Total, res.FechaLlegada, cli.Nombre, cli.Apellido FROM Reserva res inner join Habitacion hab on res.IdHabitacion = hab.IdHabitacion inner join TipoHabitacion tipoHab on tipoHab.CodTipoHabitacion = hab.CodTipoHabitacion inner join CategoriaHabitacion catHab on catHab.CodCategoriaHabitacion = hab.CodCategoriaHabitacion inner join Cliente cli on cli.idCliente = res.idCliente inner join Cuenta cu on cu.IdHabitacion = hab.IdHabitacion where res.checkIn='YES' AND cu.Activa=0 ORDER BY res.fechaLlegada ASC ", new Dictionary<string, object>());

                unaConexion.ConexionFinalizar();

                return datosReserva;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Trae todos los reportes reservas.
        /// </summary>
        /// <param name="tipoHabitacion">The tipo habitacion.</param>
        /// <param name="categoriaHabitacion">The categoria habitacion.</param>
        /// <param name="desde">The desde.</param>
        /// <param name="hasta">The hasta.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<VistaReporteReserva> TraerTodosLosReportesReservas(TipoHabitacion tipoHabitacion, CategoriaHabitacion categoriaHabitacion, DateTime desde, DateTime hasta)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@Tipo", tipoHabitacion.Tipo);
                parametros.Add("@Categoria", categoriaHabitacion.Categoria);
                parametros.Add("@Desde", desde);
                parametros.Add("@Hasta", hasta);
                var datosReserva = unaConexion.EjecutarTupla<VistaReporteReserva>("select hab.Numero, tipoHab.Tipo, catHab.Categoria, cu.Total, res.FechaLlegada, cli.Nombre, cli.Apellido FROM Reserva res inner join Habitacion hab on res.IdHabitacion = hab.IdHabitacion inner join TipoHabitacion tipoHab on tipoHab.CodTipoHabitacion = hab.CodTipoHabitacion inner join CategoriaHabitacion catHab on catHab.CodCategoriaHabitacion = hab.CodCategoriaHabitacion inner join Cliente cli on cli.idCliente = res.idCliente inner join Cuenta cu on cu.IdHabitacion = hab.IdHabitacion where res.checkIn='YES' AND cu.Activa=0 AND tipoHab.Tipo=@Tipo AND catHab.Categoria=@Categoria AND res.fechaLlegada BETWEEN @Desde AND @Hasta ORDER BY res.fechaLlegada ASC ", parametros);

                unaConexion.ConexionFinalizar();

                return datosReserva;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Trae todos los reportes reservas.
        /// </summary>
        /// <param name="tipoHabitacion">The tipo habitacion.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<VistaReporteReserva> TraerTodosLosReportesReservas(TipoHabitacion tipoHabitacion)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            //string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@Tipo", tipoHabitacion.Tipo);
                
                
                var datosReserva = unaConexion.EjecutarTupla<VistaReporteReserva>("select hab.Numero, tipoHab.Tipo, catHab.Categoria, cu.Total, res.FechaLlegada, cli.Nombre, cli.Apellido FROM Reserva res inner join Habitacion hab on res.IdHabitacion = hab.IdHabitacion inner join TipoHabitacion tipoHab on tipoHab.CodTipoHabitacion = hab.CodTipoHabitacion inner join CategoriaHabitacion catHab on catHab.CodCategoriaHabitacion = hab.CodCategoriaHabitacion inner join Cliente cli on cli.idCliente = res.idCliente inner join Cuenta cu on cu.IdHabitacion = hab.IdHabitacion where res.checkIn='YES' AND cu.Activa=0 AND tipoHab.Tipo=@Tipo ORDER BY res.fechaLlegada ASC ", parametros);

                unaConexion.ConexionFinalizar();

                return datosReserva;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Trae todos los reportes reservas.
        /// </summary>
        /// <param name="categoriaHabitacion">The categoria habitacion.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<VistaReporteReserva> TraerTodosLosReportesReservas(CategoriaHabitacion categoriaHabitacion)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            //string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@Categoria", categoriaHabitacion.Categoria);

               
                var datosReserva = unaConexion.EjecutarTupla<VistaReporteReserva>("select hab.Numero, tipoHab.Tipo, catHab.Categoria, cu.Total, res.FechaLlegada, cli.Nombre, cli.Apellido FROM Reserva res inner join Habitacion hab on res.IdHabitacion = hab.IdHabitacion inner join TipoHabitacion tipoHab on tipoHab.CodTipoHabitacion = hab.CodTipoHabitacion inner join CategoriaHabitacion catHab on catHab.CodCategoriaHabitacion = hab.CodCategoriaHabitacion inner join Cliente cli on cli.idCliente = res.idCliente inner join Cuenta cu on cu.IdHabitacion = hab.IdHabitacion where res.checkIn='YES' AND cu.Activa=0 AND catHab.Categoria =@Categoria ORDER BY res.fechaLlegada ASC ", parametros);

                unaConexion.ConexionFinalizar();

                return datosReserva;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Trae todos los reportes reservas.
        /// </summary>
        /// <param name="desde">The desde.</param>
        /// <param name="hasta">The hasta.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<VistaReporteReserva> TraerTodosLosReportesReservas(DateTime desde, DateTime hasta)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            //string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();
                Dictionary<string, object> parametros = new Dictionary<string, object>();
            

                parametros.Add("@Desde", desde);
                parametros.Add("@Hasta", hasta);
                var datosReserva = unaConexion.EjecutarTupla<VistaReporteReserva>("select hab.Numero, tipoHab.Tipo, catHab.Categoria, cu.Total, res.FechaLlegada, cli.Nombre, cli.Apellido FROM Reserva res inner join Habitacion hab on res.IdHabitacion = hab.IdHabitacion inner join TipoHabitacion tipoHab on tipoHab.CodTipoHabitacion = hab.CodTipoHabitacion inner join CategoriaHabitacion catHab on catHab.CodCategoriaHabitacion = hab.CodCategoriaHabitacion inner join Cliente cli on cli.idCliente = res.idCliente inner join Cuenta cu on cu.IdHabitacion = hab.IdHabitacion where res.checkIn='YES' AND cu.Activa=0 AND res.fechaLlegada BETWEEN @Desde AND @Hasta ORDER BY res.fechaLlegada ASC ", parametros);

                unaConexion.ConexionFinalizar();

                return datosReserva;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }

        /// <summary>
        /// Busca reserva por habitacion.
        /// </summary>
        /// <param name="numero">The numero.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<SGH.BE.Vistas.ReservaObtenida> BuscarReservaPorHabitacion(string numero)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            //string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@Numero", numero);

                var datosReserva = unaConexion.EjecutarTupla<SGH.BE.Vistas.ReservaObtenida>("Select res.idReserva, res.idHabitacion, res.idCliente from Reserva res inner join Habitacion hab on res.IdHabitacion = hab.Idhabitacion inner join Cuenta CU on CU.idCliente = res.idCliente where hab.Numero=@Numero AND CU.Activa = 1", parametros);

                unaConexion.ConexionFinalizar();

                return datosReserva;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }

        /// <summary>
        /// Modifica reserva.
        /// </summary>
        /// <param name="idReserva">The identifier reserva.</param>
        /// <param name="reservaAModificar">The reserva a modificar.</param>
        /// <returns></returns>
        public int ModificarReserva(int idReserva, Reserva reservaAModificar)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            //string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@idReserva", idReserva );
                parametros.Add("@idCliente", reservaAModificar.Cliente.idCliente);
                parametros.Add("@idHabitacion", reservaAModificar.habitacion.IdHabitacion);
                parametros.Add("@fechaLlegada", reservaAModificar.FechaLlegada);
                parametros.Add("@fechaSalida", reservaAModificar.FechaSalida);
                parametros.Add("@cantidadDias", reservaAModificar.CantidadDias);
                parametros.Add("@checkIn", reservaAModificar.CheckIn);
                parametros.Add("@EsViajeLaboral", reservaAModificar.EsViajeLaboral);
                parametros.Add("@ConNinios", reservaAModificar.ConNinios);



                unaConexion.EjecutarSinResultado("update Reserva set idCliente=@idCliente,idHabitacion=@idHabitacion,fechaLlegada=@fechaLlegada,fechaSalida=@fechaSalida,cantidadDias=@cantidadDias, checkIn=@checkIn, EsViajeLaboral=@EsViajeLaboral, ConNinios=@ConNinios where @IdReserva=IdReserva", parametros);



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
        /// Cambia estado reserva.
        /// </summary>
        /// <param name="cuenta">The cuenta.</param>
        /// <returns></returns>
        public int CambiarEstadoReserva(Cuenta cuenta)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@idReserva", cuenta.Reserva.IdReserva);
               



                unaConexion.EjecutarSinResultado("update Reserva set Activa=0 where idReserva=@idReserva ", parametros);



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
        /// Realiza check in.
        /// </summary>
        /// <param name="idReserva">The identifier reserva.</param>
        /// <param name="reservaAModificar">The reserva a modificar.</param>
        /// <returns></returns>
        public int RealizarCheckIn(int idReserva, Reserva reservaAModificar)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@idReserva", idReserva);
               
                parametros.Add("@checkIn", reservaAModificar.CheckIn);
                parametros.Add("@Activa", reservaAModificar.Activa);


                unaConexion.EjecutarSinResultado("update Reserva set checkIn=@checkIn,Activa=@Activa where @IdReserva=IdReserva", parametros);



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
        /// Borra reserva.
        /// </summary>
        /// <param name="idReserva">The identifier reserva.</param>
        /// <returns></returns>
        public int BorrarReserva(int idReserva)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
          
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
               
                parametros.Add("@idReserva", idReserva);
                unaConexion.EjecutarSinResultado("delete from Reserva where idReserva=@idReserva", parametros);


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
        /// Obtene reserva.
        /// </summary>
        /// <param name="idReserva">The identifier reserva.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<VistaReservaCuenta> ObtenerReserva(int idReserva)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);
           

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@idReserva", idReserva);

                var datosReserva = unaConexion.EjecutarTupla<VistaReservaCuenta>("select re.idReserva, re.idCliente, re.idHabitacion, re.CantidadDias, hab.Precio from reserva re inner join Habitacion hab on re.idHabitacion = hab.IdHabitacion where re.idReserva=@idReserva", parametros);

                unaConexion.ConexionFinalizar();

                return datosReserva;
                



            }
            catch (Exception ex)
            {

                throw new Exception(ex.Data.ToString());

            }
           
            


        }

    }

}

