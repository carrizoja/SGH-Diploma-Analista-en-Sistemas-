using SGH.BE;
using SGH.BE.CompositePermisos;
using SGH.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BLL
{
    /// <summary>
    /// Clase de Lógica de Negocio perteneciente a Cliente
    /// </summary>
    public class BLLCliente
    {
        DALCliente dal = new DALCliente();

        /// <summary>
        /// Registra cliente.
        /// </summary>
        /// <param name="nuevoCliente">The nuevo cliente.</param>
        /// <param name="usuarioSesion">The usuario sesion.</param>
        /// <returns></returns>
        public int RegistrarCliente(Cliente nuevoCliente, Usuario usuarioSesion)
        {
            return dal.RegistrarCliente(nuevoCliente, usuarioSesion);
        }

        /// <summary>
        /// Trae clientes.
        /// </summary>
        /// <param name="dni">The dni.</param>
        /// <returns></returns>
        public List<Cliente> TraerClientes(string dni)
        {
            return dal.TraerClientes(dni);
        }

        /// <summary>
        /// Borra clientes.
        /// </summary>
        /// <param name="dni">The dni.</param>
        /// <param name="usuarioSesion">The usuario sesion.</param>
        /// <returns></returns>
        public int BorrarClientes(string dni, Usuario usuarioSesion)
        {
            return dal.BorrarClientes(dni, usuarioSesion);
        }

        /// <summary>
        /// Modifica clientes.
        /// </summary>
        /// <param name="cliente">The cliente.</param>
        /// <param name="dni">The dni.</param>
        /// <param name="usuarioSesion">The usuario sesion.</param>
        /// <returns></returns>
        public int ModificarClientes(Cliente cliente, string dni, Usuario usuarioSesion)
        {
            return dal.ModificarClientes(cliente, dni, usuarioSesion);
        }


        /// <summary>
        /// Trae the todos los clientes.
        /// </summary>
        /// <returns></returns>
        public List<Cliente> TraerTodosLosClientes()
        {
            return dal.TraerTodosLosClientes();
        }

        /// <summary>
        /// Trae todos los clientes por apellido.
        /// </summary>
        /// <returns></returns>
        public List<Cliente> TraerTodosLosClientesApellido()
        {
            return dal.TraerTodosLosClientesApellido();
        }

        /// <summary>
        /// Trae cliente por apellido.
        /// </summary>
        /// <param name="apellido">The apellido.</param>
        /// <returns></returns>
        public List<Cliente> TraerClientePorApellido(string apellido)
        {
            return dal.TraerClientePorApellido(apellido);
        }
    }
}
