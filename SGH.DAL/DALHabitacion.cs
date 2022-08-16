using Framework.Carrizo.Persistencia;
using SGH.BE;
using SGH.BE.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SGH.DAL
{
    /// <summary>
    /// Mapper perteneciente a Habitación
    /// </summary>
    public class DALHabitacion
    {

        /// <summary>
        /// Registra habitacion.
        /// </summary>
        /// <param name="nuevaHabitacion">The nueva habitacion.</param>
        /// <returns></returns>
        public int RegistrarHabitacion(Habitacion nuevaHabitacion)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@Numero", nuevaHabitacion.Numero);

                switch (nuevaHabitacion.Tipo)
                {
                    case "single": parametros.Add("@CodTipoHabitacion", 1); break;
                    case "double": parametros.Add("@CodTipoHabitacion", 2); break;
                    case "triple": parametros.Add("@CodTipoHabitacion", 3); break;
                    case "familiar": parametros.Add("@CodTipoHabitacion", 4); break;
                }
                switch (nuevaHabitacion.Categoria)
                {
                    case "economica": parametros.Add("@CodCategoriaHabitacion", 1); break;
                    case "standard": parametros.Add("@CodCategoriaHabitacion", 2); break;
                    case "suite": parametros.Add("@CodCategoriaHabitacion", 3); break;
                }
                parametros.Add("@Precio", nuevaHabitacion.Precio);
                parametros.Add("@EstadoHabitacion", nuevaHabitacion.EstadoHabitacion);
              

                var habitacionesEnBase = unaConexion.EjecutarTupla<Habitacion>("Select * from Habitacion", parametros);

                foreach (var habitacionBase in habitacionesEnBase)
                {
                    if (habitacionBase.Numero == nuevaHabitacion.Numero)
                    {
                        return 0;
                    }
                   
                }

                unaConexion.EjecutarSinResultado("insert into Habitacion values(@Numero, @CodTipoHabitacion, @CodCategoriaHabitacion, @Precio, @EstadoHabitacion)", parametros);



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
        /// Trae todas las habitaciones.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Habitacion> TraerTodasLasHabitaciones()
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            //string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                var datosHabitacion = unaConexion.EjecutarTupla<Habitacion>("select hab.IdHabitacion, hab.Numero, tipohab.Tipo, cathab.Categoria, hab.Precio, hab.EstadoHabitacion from Habitacion as hab inner join TipoHabitacion as tipohab on hab.CodCategoriaHabitacion = tipohab.codTipoHabitacion inner join CategoriaHabitacion as cathab on hab.CodCategoriaHabitacion = cathab.codCategoriaHabitacion ", new Dictionary<string, object>());

                unaConexion.ConexionFinalizar();

                return datosHabitacion;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }

        /// <summary>
        /// Trae todas las habitaciones desocupadas.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Habitacion> TraerTodasLasHabitacionesDesocupadas()
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            //string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                var datosHabitacion = unaConexion.EjecutarTupla<Habitacion>("select hab.IdHabitacion, hab.Numero, tipohab.Tipo, cathab.Categoria, hab.Precio, hab.EstadoHabitacion from Habitacion as hab inner join TipoHabitacion as tipohab on hab.CodCategoriaHabitacion = tipohab.codTipoHabitacion inner join CategoriaHabitacion as cathab on hab.CodCategoriaHabitacion = cathab.codCategoriaHabitacion where EstadoHabitacion = 'Ocupada' ", new Dictionary<string, object>());

                unaConexion.ConexionFinalizar();

                return datosHabitacion;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Trae todos los tipos habitacion.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<TipoHabitacion> TraerTodosLosTiposHabitacion()
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            //string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                var datosTipoHabitacion = unaConexion.EjecutarTupla<TipoHabitacion>("select * from TipoHabitacion ", new Dictionary<string, object>());

                unaConexion.ConexionFinalizar();

                return datosTipoHabitacion;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Modifica habitacion.
        /// </summary>
        /// <param name="unaHabitacionModificada">The una habitacion modificada.</param>
        /// <returns></returns>
        public int ModificarHabitacion(Habitacion unaHabitacionModificada)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            //string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@IdHabitacion", unaHabitacionModificada.IdHabitacion);
                parametros.Add("@Numero", unaHabitacionModificada.Numero);
                switch (unaHabitacionModificada.Tipo)
                {
                    case "single": parametros.Add("@CodTipoHabitacion", 1); break;
                    case "double": parametros.Add("@CodTipoHabitacion", 2); break;
                    case "triple": parametros.Add("@CodTipoHabitacion", 3); break;
                }
                switch (unaHabitacionModificada.Categoria)
                {
                    case "economica": parametros.Add("@CodCategoriaHabitacion", 1); break;
                    case "standard": parametros.Add("@CodCategoriaHabitacion", 2); break;
                    case "suite": parametros.Add("@CodCategoriaHabitacion", 3); break;
                }
                parametros.Add("@Precio", unaHabitacionModificada.Precio);
                parametros.Add("@EstadoHabitacion", unaHabitacionModificada.EstadoHabitacion);
           

                unaConexion.EjecutarSinResultado("update Habitacion set Numero=@Numero,CodTipoHabitacion=@CodTipoHabitacion,CodCategoriaHabitacion=@CodCategoriaHabitacion,Precio=@Precio,EstadoHabitacion=@EstadoHabitacion where @IdHabitacion=IdHabitacion", parametros);



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
        /// Cambia estado habitacion.
        /// </summary>
        /// <param name="numeroHab">The numero hab.</param>
        /// <param name="unaHabitacionModificada">The una habitacion modificada.</param>
        /// <returns></returns>
        public int CambiarEstadoHabitacion(string numeroHab, Habitacion unaHabitacionModificada)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@Numero", numeroHab);
                parametros.Add("@EstadoHabitacion", unaHabitacionModificada.EstadoHabitacion);
               


                unaConexion.EjecutarSinResultado("update Habitacion set EstadoHabitacion=@EstadoHabitacion where @Numero=Numero", parametros);



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
        /// Libera habitacion.
        /// </summary>
        /// <param name="idHabitacion">The identifier habitacion.</param>
        /// <returns></returns>
        public int LiberarHabitacion(int idHabitacion)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@IdHabitacion", idHabitacion);
                



                unaConexion.EjecutarSinResultado("update Habitacion set EstadoHabitacion='libre' where IdHabitacion=@IdHabitacion", parametros);



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
        /// Borra habitacion.
        /// </summary>
        /// <param name="idHab">The identifier hab.</param>
        /// <returns></returns>
        public int BorrarHabitacion(int idHab)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            // string conexion = ConfigurationManager.AppSettings["AyrtonConnection"];
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                //parametros.Add("@DNI", nuevoUsuario.Dni); aca iria el id del usuario de la sesion alf
                parametros.Add("@IdHabitacion", idHab);
                unaConexion.EjecutarSinResultado("delete from Habitacion where IdHabitacion=@IdHabitacion", parametros);
                

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
        /// Obtiene el id de habitacion.
        /// </summary>
        /// <param name="numeroHab">The numero hab.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Habitacion> ObtenerIDHabitacion(string numeroHab)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@Numero", numeroHab);

                var datosHabitacion = unaConexion.EjecutarTupla<Habitacion>("Select IdHabitacion from Habitacion where Numero=@Numero", parametros);

                unaConexion.ConexionFinalizar();

                return datosHabitacion;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }

        /// <summary>
        /// Comprueba ocupacion habitacion.
        /// </summary>
        /// <param name="fechaDesde">The fecha desde.</param>
        /// <param name="numeroHab">The numero hab.</param>
        /// <param name="idCliente">The identifier cliente.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<ReservaObtenida> ComprobarOcupacionHabitacion(DateTime fechaDesde, string numeroHab, Guid idCliente)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@FechaDesde", fechaDesde);
                parametros.Add("@IdCliente", idCliente);
                parametros.Add("@Numero", numeroHab);

                var datosReserva = unaConexion.EjecutarTupla<ReservaObtenida>("use SGH select res.idReserva, hab.IdHabitacion, res.idCliente from Habitacion hab inner join Reserva res on res.idHabitacion = hab.IdHabitacion where (res.idCliente = @IdCliente OR res.idCliente <> @IdCliente) AND hab.Numero = @Numero AND res.Activa=1 AND @FechaDesde BETWEEN res.FechaLlegada and res.FechaSalida", parametros);

                unaConexion.ConexionFinalizar();

                return datosReserva;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Comprueba ocupacion habitacion modificar.
        /// </summary>
        /// <param name="fechaDesde">The fecha desde.</param>
        /// <param name="numeroHab">The numero hab.</param>
        /// <param name="idCliente">The identifier cliente.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<ReservaObtenida> ComprobarOcupacionHabitacionModificar(DateTime fechaDesde, string numeroHab, Guid idCliente)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@FechaDesde", fechaDesde);
                parametros.Add("@IdCliente", idCliente);
                parametros.Add("@Numero", numeroHab);

                var datosReserva = unaConexion.EjecutarTupla<ReservaObtenida>("use SGH select res.idReserva, hab.IdHabitacion, res.idCliente from Habitacion hab inner join Reserva res on res.idHabitacion = hab.IdHabitacion where res.idCliente <> @IdCliente AND hab.Numero = @Numero AND res.Activa=1 AND @FechaDesde BETWEEN res.FechaLlegada and res.FechaSalida", parametros);

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
