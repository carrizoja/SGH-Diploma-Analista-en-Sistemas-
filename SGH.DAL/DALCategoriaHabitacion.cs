using Framework.Carrizo.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGH.BE;
using System.Configuration;


namespace SGH.DAL
{
    /// <summary>
    /// Mapper perteneciente a la categoría de la habitación
    /// </summary>
    public class DALCategoriaHabitacion
    {
        /// <summary>
        /// Registra  categoria habitacion.
        /// </summary>
        /// <param name="nuevaCategoriaHabitacion">The nueva categoria habitacion.</param>
        /// <returns></returns>
        public int RegistrarCategoriaHabitacion(BE.CategoriaHabitacion nuevaCategoriaHabitacion)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@CodCategoriaHabitacion", nuevaCategoriaHabitacion.CodCategoriaHabitacion);
                parametros.Add("@Categoria", nuevaCategoriaHabitacion.Categoria);
               

                var CategoriasHabitacionEnBase = unaConexion.EjecutarTupla<CategoriaHabitacion>("Select * from CategoriaHabitacion", parametros);

                foreach (var CategoriaHabitacionBase in CategoriasHabitacionEnBase)
                {
                    if (CategoriaHabitacionBase.CodCategoriaHabitacion == nuevaCategoriaHabitacion.CodCategoriaHabitacion)
                    {
                        return 0;
                    }
                    if (CategoriaHabitacionBase.Categoria == nuevaCategoriaHabitacion.Categoria)
                    {
                        return 2;
                    }
                }


                unaConexion.EjecutarSinResultado("insert into CategoriaHabitacion values(@CodCategoriaHabitacion,@Categoria)", parametros);
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
        /// Traers the todos las categoria habitacion.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<CategoriaHabitacion> TraerTodosLasCategoriaHabitacion()
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                var datosCategoriaHabitacion = unaConexion.EjecutarTupla<CategoriaHabitacion>("Select * from CategoriaHabitacion ", new Dictionary<string, object>());

                unaConexion.ConexionFinalizar();

                return datosCategoriaHabitacion;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Modifica categoria habitacion.
        /// </summary>
        /// <param name="unaCategoriaHabitacionModificada">The una categoria habitacion modificada.</param>
        /// <param name="CodCategoriaHab">The cod categoria hab.</param>
        /// <returns></returns>
        public int ModificarCategoriaHabitacion(CategoriaHabitacion unaCategoriaHabitacionModificada, string CodCategoriaHab)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // // string conexion = ConfigurationManager.AppSettings["SGHConnection"];

            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
               
                parametros.Add("@CodCategoriaHabitacionActual", CodCategoriaHab);
                parametros.Add("@CodCategoriaHabitacion", unaCategoriaHabitacionModificada.CodCategoriaHabitacion);
               
                unaConexion.EjecutarSinResultado("update CategoriaHabitacion set CodCategoriaHabitacion=@CodCategoriaHabitacion,Categoria=@Categoria where CodCategoriaHabitacion=@CodCategoriaHabitacionActual", parametros);

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
        /// Borra categoria habitacion.
        /// </summary>
        /// <param name="CodCategoriaHabitacion">The cod categoria habitacion.</param>
        /// <returns></returns>
        public int BorrarCategoriaHabitacion(string CodCategoriaHabitacion)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            //// string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                //parametros.Add("@DNI", nuevoUsuario.Dni); aca iria el id del usuario de la sesion alf
                parametros.Add("@CodCategoriaHabitacion", CodCategoriaHabitacion);
                unaConexion.EjecutarSinResultado("delete from CategoriaHabitacion where CodCategoriaHabitacion=@CodCategoriaHabitacion", parametros);

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
        /// Trae categoria habitación
        /// </summary>
        /// <param name="catHab">The cat hab.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<CategoriaHabitacion> TraerCategoriaHab(string catHab)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();

            //// string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@codCategoriaHabitacion", catHab);

                var datosCatHab = unaConexion.EjecutarTupla<CategoriaHabitacion>("Select * from CategoriaHabitacion where codCategoriaHabitacion=@codCategoriaHabitacion", parametros);

                unaConexion.ConexionFinalizar();

                return datosCatHab;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }

    }
}
