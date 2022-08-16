using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Carrizo.Persistencia;
using SGH.BE;
using System.Configuration;




namespace SGH.DAL
{
    /// <summary>
    /// Mapper correspondiente al Tipo de Habitación
    /// </summary>
    public class DALTipoHabitacion
    {
        /// <summary>
        /// Registra tipo habitacion.
        /// </summary>
        /// <param name="nuevoTipoHabitacion">The nuevo tipo habitacion.</param>
        /// <returns></returns>
        public int RegistrarTipoHabitacion(BE.TipoHabitacion nuevoTipoHabitacion)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@CodTipoHabitacion", nuevoTipoHabitacion.CodTipoHabitacion);
                parametros.Add("@Tipo", nuevoTipoHabitacion.Tipo);


                var TiposHabitacionEnBase = unaConexion.EjecutarTupla<TipoHabitacion>("Select * from TipoHabitacion", parametros);

                foreach (var TipoHabitacionBase in TiposHabitacionEnBase)
                {
                    if (TipoHabitacionBase.CodTipoHabitacion == nuevoTipoHabitacion.CodTipoHabitacion)
                    {
                        return 0;
                    }
                    if (TipoHabitacionBase.Tipo == nuevoTipoHabitacion.Tipo)
                    {
                        return 2;
                    }
                }


                unaConexion.EjecutarSinResultado("insert into TipoHabitacion values(@CodTipoHabitacion,@Tipo)", parametros);
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
        /// Trae todos los tipo habitacion.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<TipoHabitacion> TraerTodosLosTipoHabitacion()
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                var datosTipoHabitacion = unaConexion.EjecutarTupla<TipoHabitacion>("Select * from TipoHabitacion ", new Dictionary<string, object>());

                unaConexion.ConexionFinalizar();

                return datosTipoHabitacion;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Modifica tipo habitacion.
        /// </summary>
        /// <param name="unTipoHabitacionModificado">The un tipo habitacion modificado.</param>
        /// <param name="CodTipoHab">The cod tipo hab.</param>
        /// <returns></returns>
        public int ModificarTipoHabitacion(TipoHabitacion unTipoHabitacionModificado, string CodTipoHab)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();

                parametros.Add("@CodTipoHabitacionActual", CodTipoHab);
                parametros.Add("@CodTipoHabitacion", unTipoHabitacionModificado.CodTipoHabitacion);

                unaConexion.EjecutarSinResultado("update TipoHabitacion set CodTipoHabitacion=@CodTipoHabitacion,Tipo=@Tipo where CodTipoHabitacion=@CodTipoHabitacionActual", parametros);

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
        /// Borra tipo habitacion.
        /// </summary>
        /// <param name="CodTipoHabitacion">The cod tipo habitacion.</param>
        /// <returns></returns>
        public int BorrarTipoHabitacion(string CodTipoHabitacion)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                //parametros.Add("@DNI", nuevoUsuario.Dni); aca iria el id del usuario de la sesion alf
                parametros.Add("@CodTipoHabitacion", CodTipoHabitacion);
                unaConexion.EjecutarSinResultado("delete from TipoHabitacion where CodTipoHabitacion=@CodTipoHabitacion", parametros);

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
        /// Trae tipo habitación
        /// </summary>
        /// <param name="TipoHab">The tipo hab.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<TipoHabitacion> TraerTipoHab(string TipoHab)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@codTipoHabitacion", TipoHab);

                var datosTipoHab = unaConexion.EjecutarTupla<TipoHabitacion>("Select * from TipoHabitacion where codTipoHabitacion=@codTipoHabitacion", parametros);

                unaConexion.ConexionFinalizar();

                return datosTipoHab;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }

    }
}
