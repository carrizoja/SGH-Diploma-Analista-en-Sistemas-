using Framework.Carrizo.Persistencia;
using SGH.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SGH.Servicios
{
    /// <summary>
    /// Mapper de la Bitácora
    /// </summary>
    public class DALBitacora
    {
        /// <summary>
        /// Graba bitacora.
        /// </summary>
        /// <param name="unaBitacora">The una bitacora.</param>
        public void GrabarBitacora(BE.Bitacora unaBitacora)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);
            try
            {


                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();

                parametros.Add("@IdBitacora", Guid.NewGuid());
                parametros.Add("@Descripcion", unaBitacora.descripcion); //hardcoded values. CHANGE THIS!
                parametros.Add("@Fecha", unaBitacora.fecha);
                parametros.Add("@IdUsuario", unaBitacora.usuario.IdUsuario);
                parametros.Add("@Formulario", unaBitacora.formulario);

                //unaConexion.EjecutarSinResultado("Insert into Bitacora(IdBitacora,Descripcion) values(@IdBitacora,@Descripcion)", parametros);
                unaConexion.EjecutarSinResultado("Insert into Bitacora values(@IdBitacora,@Descripcion,@Fecha,@IdUsuario,@Formulario)", parametros);
                //   unaConexion.EjecutarSinResultado("Insert into Bitacora(IdBitacora,Descripcion) values('66588132-27BF-40FC-BC5E-76E2A027AA64','BLABLABLA')", parametros);


            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();
                throw;
            }

            unaConexion.TransaccionAceptar();
            unaConexion.ConexionFinalizar();

        }
        /// <summary>
        /// Lee bitacora.
        /// </summary>
        /// <param name="unaBitacora">The una bitacora.</param>
        public void LeerBitacora(BE.Bitacora unaBitacora)
        {

        }
        /// <summary>
        /// Trae bitacoras.
        /// </summary>
        /// <returns></returns>
        public List<BE.BitacoraDatos> TraerBitacoras()
        {

            try
            {

                SqlServerConnection unaConexion = new SqlServerConnection();
                string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
                // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
                unaConexion.NuevaConexion(conexion);

               

                var resultado = unaConexion.EjecutarTupla<BE.BitacoraDatos>("Select Usuario.Nombre as Usuario, Bitacora.Fecha Fecha, Bitacora.Descripcion Descripcion,Bitacora.Formulario Formulario from Bitacora inner join Usuario on Bitacora.IdUsuario=Usuario.IdUsuario ORDER BY Fecha desc", new Dictionary<string, object>());

                unaConexion.ConexionFinalizar();

                return resultado;
            }
            catch (Exception)
            {
                throw;
            }

        }
        /// <summary>
        /// Trae formularios bitacora.
        /// </summary>
        /// <returns></returns>
        public List<BE.BitacoraDatos> TraerFormulariosBitacora()
        {

            try
            {

                SqlServerConnection unaConexion = new SqlServerConnection();
                string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
                // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
                unaConexion.NuevaConexion(conexion);



                var resultado = unaConexion.EjecutarTupla<BE.BitacoraDatos>("select distinct Formulario from Bitacora order by Formulario asc ", new Dictionary<string, object>());

                unaConexion.ConexionFinalizar();

                return resultado;
            }
            catch (Exception)
            {
                throw;
            }

        }
        /// <summary>
        /// Trae bitacoras.
        /// </summary>
        /// <param name="unUsuario">The un usuario.</param>
        /// <param name="formulario">The formulario.</param>
        /// <param name="fechaDesde">The fecha desde.</param>
        /// <param name="fechaHasta">The fecha hasta.</param>
        /// <returns></returns>
        public List<BE.BitacoraDatos> TraerBitacoras(SGH.BE.CompositePermisos.Usuario unUsuario, string formulario, DateTime fechaDesde, DateTime fechaHasta)
        {

            try
            {

                SqlServerConnection unaConexion = new SqlServerConnection();
                string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
                // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
                unaConexion.NuevaConexion(conexion);

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@IdUsuario", unUsuario.IdUsuario);
                parametros.Add("@Formulario", formulario);
                parametros.Add("@FechaDesde", fechaDesde);
                parametros.Add("@FechaHasta", fechaHasta);


                var resultado = unaConexion.EjecutarTupla<BE.BitacoraDatos>("Select Usuario.Nombre as Usuario, Bitacora.Fecha Fecha, Bitacora.Descripcion Descripcion, Bitacora.Formulario Formulario from Bitacora inner join Usuario on Bitacora.IdUsuario = Usuario.IdUsuario where Usuario.IdUsuario = @IdUsuario AND Bitacora.Formulario = @Formulario AND Fecha BETWEEN @FechaDesde AND @FechaHasta ORDER BY Fecha desc", parametros);

                unaConexion.ConexionFinalizar();

                return resultado;
            }
            catch (Exception)
            {
                throw;
            }

        }
        /// <summary>
        /// Trae bitacoras.
        /// </summary>
        /// <param name="formulario">The formulario.</param>
        /// <param name="fechaDesde">The fecha desde.</param>
        /// <param name="fechaHasta">The fecha hasta.</param>
        /// <returns></returns>
        public List<BE.BitacoraDatos> TraerBitacoras(string formulario, DateTime fechaDesde, DateTime fechaHasta)
        {

            try
            {

                SqlServerConnection unaConexion = new SqlServerConnection();
                string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
                // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
                unaConexion.NuevaConexion(conexion);

                Dictionary<string, object> parametros = new Dictionary<string, object>();

                parametros.Add("@Formulario", formulario);
                parametros.Add("@FechaDesde", fechaDesde);
                parametros.Add("@FechaHasta", fechaHasta);


                var resultado = unaConexion.EjecutarTupla<BE.BitacoraDatos>("Select Usuario.Nombre as Usuario, Bitacora.Fecha Fecha, Bitacora.Descripcion Descripcion, Bitacora.Formulario Formulario from Bitacora inner join Usuario on Bitacora.IdUsuario = Usuario.IdUsuario where Formulario=@Formulario AND Fecha BETWEEN @FechaDesde AND @FechaHasta ORDER BY Fecha desc", parametros);

                unaConexion.ConexionFinalizar();

                return resultado;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// Trae bitacoras.
        /// </summary>
        /// <param name="fechaDesde">The fecha desde.</param>
        /// <param name="fechaHasta">The fecha hasta.</param>
        /// <returns></returns>
        public List<BE.BitacoraDatos> TraerBitacoras(DateTime fechaDesde, DateTime fechaHasta)
        {

            try
            {

                SqlServerConnection unaConexion = new SqlServerConnection();
                string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
                // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
                unaConexion.NuevaConexion(conexion);

                Dictionary<string, object> parametros = new Dictionary<string, object>();

               
                parametros.Add("@FechaDesde", fechaDesde);
                parametros.Add("@FechaHasta", fechaHasta);


                var resultado = unaConexion.EjecutarTupla<BE.BitacoraDatos>("Select Usuario.Nombre as Usuario, Bitacora.Fecha Fecha, Bitacora.Descripcion Descripcion, Bitacora.Formulario Formulario from Bitacora inner join Usuario on Bitacora.IdUsuario = Usuario.IdUsuario where Fecha BETWEEN @FechaDesde AND @FechaHasta ORDER BY Fecha desc", parametros);

                unaConexion.ConexionFinalizar();

                return resultado;
            }
            catch (Exception)
            {
                throw;
            }

        }
        /// <summary>
        /// Trae bitacoras.
        /// </summary>
        /// <param name="unUsuario">The un usuario.</param>
        /// <param name="fechaDesde">The fecha desde.</param>
        /// <param name="fechaHasta">The fecha hasta.</param>
        /// <returns></returns>
        public List<BE.BitacoraDatos> TraerBitacoras(SGH.BE.CompositePermisos.Usuario unUsuario, DateTime fechaDesde, DateTime fechaHasta)
        {

            try
            {

                SqlServerConnection unaConexion = new SqlServerConnection();
                string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
                //string conexion = ConfigurationManager.AppSettings["SGHConnection"];
                unaConexion.NuevaConexion(conexion);

                Dictionary<string, object> parametros = new Dictionary<string, object>();

                parametros.Add("@IdUsuario", unUsuario.IdUsuario);
                parametros.Add("@FechaDesde", fechaDesde);
                parametros.Add("@FechaHasta", fechaHasta);


                var resultado = unaConexion.EjecutarTupla<BE.BitacoraDatos>("Select Usuario.Nombre as Usuario, Bitacora.Fecha Fecha, Bitacora.Descripcion Descripcion, Bitacora.Formulario Formulario from Bitacora inner join Usuario on Bitacora.IdUsuario = Usuario.IdUsuario where Usuario.IdUsuario = @IdUsuario AND Fecha BETWEEN @FechaDesde AND @FechaHasta ORDER BY Fecha desc", parametros);

                unaConexion.ConexionFinalizar();

                return resultado;
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}
