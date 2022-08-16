using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGH.BE;
using SGH.BE.Vistas;
using System.Data.SqlClient;
using System.Data;
using Framework.Carrizo.Persistencia;
using System.Configuration;

namespace SGH.Servicios
{
    /// <summary>
    /// Mapper para la gestión de cambios
    /// </summary>
    public class DALGestionCambios
    {
        /// <summary>
        /// Traer todo gestion cambios.
        /// </summary>
        /// <returns></returns>
        public List<GcambiosTodosVista> TraerTodoGestionCambios()
        {

            try
            {

                SqlServerConnection unaConexion = new SqlServerConnection();
                string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
                //string conexion = ConfigurationManager.AppSettings["SGHConnection"];
                unaConexion.NuevaConexion(conexion);



                var resultado = unaConexion.EjecutarTupla<GcambiosTodosVista>("USE SGH SELECT CT.SYS_CHANGE_VERSION, CT.SYS_CHANGE_OPERATION, CLI.* FROM CHANGETABLE(CHANGES CLIENTE, 0) as CT JOIN CLIENTE CLI ON CT.idCliente = CLI.idCliente ORDER BY SYS_CHANGE_VERSION ", new Dictionary<string, object>());

                unaConexion.ConexionFinalizar();

                return resultado;
            }
            catch (Exception)
            {
                throw;
            }

        }
        /// <summary>
        /// Traer todo gestion cambios delete.
        /// </summary>
        /// <returns></returns>
        public List<GcambiosDeleteVista> TraerTodoGestionCambiosDelete()
        {

            try
            {

                SqlServerConnection unaConexion = new SqlServerConnection();
                string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
             //   string conexion = ConfigurationManager.AppSettings["SGHConnection"];
                unaConexion.NuevaConexion(conexion);



                var resultado = unaConexion.EjecutarTupla<GcambiosDeleteVista>("SELECT CT.SYS_CHANGE_VERSION, CT.SYS_CHANGE_OPERATION FROM CHANGETABLE (CHANGES CLIENTE, 0) as CT LEFT OUTER JOIN CLIENTE CLI ON CT.idCliente = CLI.idCliente ORDER BY SYS_CHANGE_VERSION ", new Dictionary<string, object>());

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
