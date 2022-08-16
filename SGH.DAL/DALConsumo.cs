using SGH.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Framework.Carrizo.Persistencia;
using SGH.BE.Vistas;

namespace SGH.DAL
{
    /// <summary>
    /// Mapper correspondiente a Consumo
    /// </summary>
    public class DALConsumo
    {
        /// <summary>
        /// Carga consumo.
        /// </summary>
        /// <param name="unConsumo">The un consumo.</param>
        /// <returns></returns>
        public int CargarConsumo(Consumo unConsumo)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);
            DateTime fechaDePedido = DateTime.Now;

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@IdServicio", unConsumo.Servicio.IdServicio);
                parametros.Add("@IdHabitacion", unConsumo.Habitacion.IdHabitacion);
                parametros.Add("@IdCliente", unConsumo.Cliente.idCliente);
                parametros.Add("@Precio", unConsumo.Precio);
                parametros.Add("@Descripcion", unConsumo.Descripcion);
                parametros.Add("@FechaDePedido", fechaDePedido);
                parametros.Add("@IdReserva", unConsumo.Reserva.IdReserva);

                unaConexion.EjecutarSinResultado("insert into Consumo (IdServicio,IdHabitacion,Precio,Descripcion, IdCliente, FechaDePedido, IdReserva) values(@IdServicio,@IdHabitacion,@Precio,@Descripcion,@IdCliente,@FechaDePedido,@IdReserva)", parametros);



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
        /// Listaconsumos por habitacion.
        /// </summary>
        /// <param name="numero">The numero.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<SGH.BE.Vistas.ListaDeConsumosVista> ListarConsumosPorHabitacion(string numero)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@Numero", numero);

                var datosConsumos = unaConexion.EjecutarTupla<SGH.BE.Vistas.ListaDeConsumosVista>("Select distinct con.Descripcion, con.Precio, cli.Nombre, cli.Apellido, con.FechaDePedido from Consumo con inner join Servicio ser on con.IdServicio = ser.IdServicio inner join Cliente cli on cli.idCliente = con.IdCliente inner join Habitacion hab on con.IdHabitacion = hab.IdHabitacion inner join Reserva res on con.IdReserva = res.idReserva where hab.Numero =@Numero and hab.EstadoHabitacion = 'Ocupada' AND con.Activo=1 ", parametros);

                unaConexion.ConexionFinalizar();

                return datosConsumos;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }

        /// <summary>
        /// Cierra consumos.
        /// </summary>
        /// <param name="cuenta">The cuenta.</param>
        /// <returns></returns>
        public int CerrarConsumos(Cuenta cuenta)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);
            
            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@IdHabitacion", cuenta.Habitacion.IdHabitacion);
                parametros.Add("@IdCliente", cuenta.Cliente.idCliente);
                parametros.Add("@IdReserva", cuenta.Reserva.IdReserva);




                unaConexion.EjecutarSinResultado("update Consumo set Activo=0 where IdHabitacion=@IdHabitacion AND IdCliente=@IdCliente AND IdReserva=@IdReserva", parametros);



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
