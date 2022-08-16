using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGH.BE;
using Framework.Carrizo.Persistencia;


namespace SGH.Servicios
{
    /// <summary>
    /// Clase Entidad de Negocio para el Gestor de Cambios
    /// </summary>
    /// <seealso cref="SGH.Servicios.IGestorDeCambios{SGH.BE.Cliente}" />
    public class GestorDeCambiosCliente : IGestorDeCambios<Cliente>
    {
        /// <summary>
        /// Audita insert.
        /// </summary>
        /// <param name="nuevoCliente">The nuevo cliente.</param>
        public void AuditarInsert(Cliente nuevoCliente)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
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

                unaConexion.EjecutarSinResultado("insert into tablaauditoriacliente values(@Nombre, @Apellido, @Dni, @Edad, @Email, @Telefono,SYSDATETIME())", parametros);

                unaConexion.TransaccionAceptar();
                unaConexion.ConexionFinalizar();
            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();

            }
        }
        /// <summary>
        /// Audita update.
        /// </summary>
        /// <param name="Objeto">The objeto.</param>
        /// <exception cref="NotImplementedException"></exception>
        public void AuditarUpdate(Cliente Objeto)
        {
            throw new NotImplementedException();
        }
    }

      
    
}
