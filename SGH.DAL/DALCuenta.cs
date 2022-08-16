using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGH.BE;
using Framework.Carrizo.Persistencia;
using SGH.BE.Vistas;
using System.Configuration;

namespace SGH.DAL
{
    /// <summary>
    /// Mapper correspondiente a Cuenta
    /// </summary>
    public class DALCuenta
    {
        /// <summary>
        /// Crea cuenta.
        /// </summary>
        /// <param name="unaReserva">The una reserva.</param>
        /// <param name="cuenta">The cuenta.</param>
        /// <returns></returns>
        public int CrearCuenta(Reserva unaReserva, Cuenta cuenta)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);
            
            bool activa = true;
            DateTime fechaCreacion = DateTime.Now;
            
            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@idCliente", unaReserva.Cliente.idCliente);
                parametros.Add("@idHabitacion", unaReserva.habitacion.IdHabitacion);
                parametros.Add("@Total", cuenta.Total);
                parametros.Add("@Activa", Convert.ToInt32(activa));
                parametros.Add("@FechaCreacion", fechaCreacion);
                parametros.Add("@IdReserva", unaReserva.IdReserva);
                
                unaConexion.EjecutarSinResultado("insert into Cuenta (idCliente,idHabitacion,Total,Activa,FechaCreacion,IdReserva) values(@idCliente,@idHabitacion,@Total,@Activa,@fechaCreacion,@IdReserva)", parametros);



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
        /// Obtiene la cuenta.
        /// </summary>
        /// <param name="unaReserva">The una reserva.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<CuentaObtenida> ObtenerCuenta(Reserva unaReserva)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                
                parametros.Add("@IdHabitacion", unaReserva.habitacion.IdHabitacion);
                parametros.Add("@idCliente", unaReserva.Cliente.idCliente);
                parametros.Add("@idReserva", unaReserva.IdReserva);

                var datosCuenta = unaConexion.EjecutarTupla<CuentaObtenida>("Select IdCuenta, Total, IdHabitacion, idCliente, IdReserva from Cuenta where idHabitacion=@IdHabitacion AND idCliente=@idCliente AND IdReserva=@IdReserva", parametros);

                unaConexion.ConexionFinalizar();

                return datosCuenta;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }

        /// <summary>
        /// Obtiene cuenta final.
        /// </summary>
        /// <param name="apellido">The apellido.</param>
        /// <param name="numeroHab">The numero hab.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<CuentaObtenida> ObtenerCuentaFinal(string apellido, string numeroHab)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();

                parametros.Add("@Apellido", apellido);
                parametros.Add("@Numero", numeroHab);

                var datosCuenta = unaConexion.EjecutarTupla<CuentaObtenida>("Select CU.IdCuenta, CU.Total, CU.IdHabitacion, CU.idCliente, CU.IdReserva from Cuenta CU inner join Cliente cli on CU.idCliente = Cli.idCliente inner join Habitacion hab on hab.IdHabitacion = CU.IdHabitacion inner join Reserva res on res.idReserva = CU.IdReserva where hab.Numero = @Numero AND cli.Apellido=@Apellido AND CU.Activa=1", parametros);

                unaConexion.ConexionFinalizar();

                return datosCuenta;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }

        /// <summary>
        /// Carga consumo cuenta.
        /// </summary>
        /// <param name="cuenta">The cuenta.</param>
        /// <returns></returns>
        public int CargarConsumoCuenta(Cuenta cuenta)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@idCuenta", cuenta.IdCuenta);
                parametros.Add("@Total", cuenta.Total );



                unaConexion.EjecutarSinResultado("update Cuenta set Total=@Total where idCuenta=@idCuenta", parametros);



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
        /// Cierra la cuenta.
        /// </summary>
        /// <param name="idCuenta">The identifier cuenta.</param>
        /// <returns></returns>
        public int CerrarCuenta(int idCuenta)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);
            DateTime fechaCierre = DateTime.Now;
            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@IdCuenta", idCuenta);
                parametros.Add("FechaCierre", fechaCierre);
                



                unaConexion.EjecutarSinResultado("update Cuenta set FechaCierre=@FechaCierre, Activa=0 where IdCuenta=@IdCuenta", parametros);



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

    }
}
