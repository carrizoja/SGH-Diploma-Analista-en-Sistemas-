using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGH.BE;
using SGH.BE.CompositePermisos;
using SGH.Servicios;
using Framework.Carrizo.Persistencia;
using System.Configuration;

namespace SGH.DAL
{
    /// <summary>
    /// Mapper correspondiente a Cliente
    /// </summary>
    public class DALCliente
    {
        /// <summary>
        /// Registra cliente.
        /// </summary>
        /// <param name="nuevoCliente">The nuevo cliente.</param>
        /// <param name="usuarioSesion">The usuario sesion.</param>
        /// <returns></returns>
        public int RegistrarCliente(Cliente nuevoCliente, Usuario usuarioSesion)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();

           // // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@Nombre", nuevoCliente.Nombre);
                parametros.Add("@Apellido", nuevoCliente.Apellido);
                parametros.Add("@Dni", nuevoCliente.Dni);
                parametros.Add("@Edad", nuevoCliente.Edad);
                parametros.Add("@Email", nuevoCliente.Email);
                parametros.Add("@Telefono", nuevoCliente.Telefono);
               
                var clientesEnBase = unaConexion.EjecutarTupla<Cliente>("Select * from cliente", parametros);

                foreach (var clienteBase in clientesEnBase)
                {
                    if (clienteBase.Dni == nuevoCliente.Dni)
                    {
                        return 0;
                    }
                    if (clienteBase.Email.ToUpper() == nuevoCliente.Email.ToUpper())
                    {
                        return 2;
                    }
                }

                unaConexion.EjecutarSinResultado("insert into cliente values(NEWID(),@Nombre, @Apellido, @Dni, @Edad, @Email, @Telefono)", parametros);



                unaConexion.TransaccionAceptar();
                unaConexion.ConexionFinalizar();

               

                GestorDeCambiosCliente gestor = new GestorDeCambiosCliente();
                gestor.AuditarInsert(nuevoCliente);


            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();

            }
            return 1;
        }

        /// <summary>
        /// Trae the todos los clientes.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Cliente> TraerTodosLosClientes()
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            //// string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                var datosCliente = unaConexion.EjecutarTupla<Cliente>("Select * from Cliente", new Dictionary<string, object>());

                unaConexion.ConexionFinalizar();

                return datosCliente;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Trae todos los clientes apellido.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Cliente> TraerTodosLosClientesApellido()
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            //// string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                var datosCliente = unaConexion.EjecutarTupla<Cliente>("Select CLI.idCliente, CLI.Apellido, CLI.Nombre, CLI.Dni from Cliente CLI ", new Dictionary<string, object>());

                unaConexion.ConexionFinalizar();

                return datosCliente;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Modifica  clientes.
        /// </summary>
        /// <param name="cliente">The cliente.</param>
        /// <param name="dni">The dni.</param>
        /// <param name="usuarioSesion">The usuario sesion.</param>
        /// <returns></returns>
        public int ModificarClientes(Cliente cliente, string dni, Usuario usuarioSesion)
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
                parametros.Add("@Dni", dni);
                parametros.Add("@Nombre", cliente.Nombre);
                parametros.Add("@Apellido", cliente.Apellido);
                parametros.Add("@Edad", cliente.Edad.ToString());
                parametros.Add("@Email", cliente.Email);
                parametros.Add("@Telefono", cliente.Telefono.ToString());
                unaConexion.EjecutarSinResultado("update cliente set Nombre=@Nombre,Apellido=@Apellido,Edad=@Edad,Email=@Email,Telefono=@Telefono where Dni=@DNI", parametros);

                unaConexion.TransaccionAceptar();
                unaConexion.ConexionFinalizar();

                //object[] args = new object[] { cliente.Nombre, cliente.Apellido,cliente.Edad.ToString(), cliente.Email, cliente.Telefono.ToString(), dni };

                //string queryAuditable = string.Format("update cliente set Nombre = {0}, Apellido = {1}, Edad = {2}, Email = {3}, Telefono = {4} where Dni = {5}", args);
                //GestionDeCambios gestor = new GestionDeCambios();
                //gestor.AuditarUpdate(usuarioSesion.IdUsuario, usuarioSesion.Nombre, "Cliente", queryAuditable);

                GestorDeCambiosCliente gestor = new GestorDeCambiosCliente();
                gestor.AuditarInsert(cliente);

                return 1;

            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();
                return 0;
            }
        }

        /// <summary>
        /// Borra clientes.
        /// </summary>
        /// <param name="dni">The dni.</param>
        /// <param name="usuarioSesion">The usuario sesion.</param>
        /// <returns></returns>
        public int BorrarClientes(string dni, Usuario usuarioSesion)
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
                parametros.Add("@DNI", dni);
                unaConexion.EjecutarSinResultado("delete from cliente where Dni=@DNI", parametros);

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
        /// Trae clientes.
        /// </summary>
        /// <param name="dni">The dni.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Cliente> TraerClientes(string dni)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@DNI", dni);

                var datosCliente = unaConexion.EjecutarTupla<Cliente>("Select * from cliente where DNI=@DNI", parametros);

                unaConexion.ConexionFinalizar();

                return datosCliente;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }

        /// <summary>
        /// Trae cliente por apellido.
        /// </summary>
        /// <param name="unApellido">The un apellido.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Cliente> TraerClientePorApellido(string unApellido)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@Apellido", unApellido);

                var datosCliente = unaConexion.EjecutarTupla<Cliente>("Select IdCliente from cliente where Apellido=@Apellido", parametros);

                unaConexion.ConexionFinalizar();

                return datosCliente;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }


    }
}
