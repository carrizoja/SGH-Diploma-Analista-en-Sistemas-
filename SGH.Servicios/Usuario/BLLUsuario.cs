using SGH.BE.CompositePermisos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGH.Servicios;

namespace SGH.BLL
{
    /// <summary>
    /// Clase Lógica de Negocio del Usuario
    /// </summary>
    public class BLLUsuario
    {
        private DALUsuario dal = new DALUsuario();

        /// <summary>
        /// Registra usuario.
        /// </summary>
        /// <param name="nuevoUsuario">The nuevo usuario.</param>
        /// <returns></returns>
        public int RegistrarUsuario(Usuario nuevoUsuario)
        {
            return dal.RegistrarUsuario(nuevoUsuario);
        }
        /// <summary>
        /// Inicia sesion.
        /// </summary>
        /// <param name="usuario">The usuario.</param>
        /// <returns></returns>
        public bool IniciarSesion(Usuario usuario)
        {
            var resultado = dal.IniciarSesion(usuario);
            return resultado;
        }
        /// <summary>
        /// Trae usuario.
        /// </summary>
        /// <param name="dni">The dni.</param>
        /// <returns></returns>
        public string TraerUsuario(string dni)
        {
            return dal.TraerUsuario(dni);
        }
        /// <summary>
        /// Trae roles para agregar.
        /// </summary>
        /// <returns></returns>
        public List<Familia> TraerRolesParaAgregar()
        {
            return dal.TraerRolesParaAgregar();
        }
        /// <summary>
        /// Trae permiso simples.
        /// </summary>
        /// <param name="idSelected">The identifier selected.</param>
        /// <returns></returns>
        public List<Patente> TraerPermisoSimples(string idSelected)
        {
            return dal.TraerPermisoSimples(idSelected);
        }
        /// <summary>
        /// Agrega rol.
        /// </summary>
        /// <param name="nuevoUsuario">The nuevo usuario.</param>
        /// <param name="dni">The dni.</param>
        public void AgregarRol(Usuario nuevoUsuario, string dni)
        {
            dal.AgregarRol(nuevoUsuario, dni);
        }
        /// <summary>
        /// Trae permiso usuario.
        /// </summary>
        /// <param name="dni">The dni.</param>
        /// <returns></returns>
        public List<Patente> TraerPermisoUsuario(string dni)
        {
            return dal.TraerPermisoUsuario(dni);
        }
        /// <summary>
        /// Trae todos los usuarios.
        /// </summary>
        /// <returns></returns>
        public List<Usuario> TraerTodosLosUsuarios()
        {
            return dal.TraerTodosLosUsuarios();
        }
        /// <summary>
        /// Trae permiso simples por dni.
        /// </summary>
        /// <param name="dni">The dni.</param>
        /// <returns></returns>
        public List<Familia> TraerPermisoSimplesPorDni(string dni)
        {
            return dal.TraerPermisoSimplesPorDni(dni);
        }
        /// <summary>
        /// Modifica usuario.
        /// </summary>
        /// <param name="unUsuarioModificado">The un usuario modificado.</param>
        /// <param name="dni">The dni.</param>
        /// <returns></returns>
        public int ModificarUsuario(Usuario unUsuarioModificado, string dni)
        {
            return dal.ModificarUsuario(unUsuarioModificado, dni);
        }
        /// <summary>
        /// Trae permiso usuario que no tiene asignados.
        /// </summary>
        /// <param name="dni">The dni.</param>
        /// <returns></returns>
        public List<Patente> TraerPermisoUsuarioQueNoTieneAsignados(string dni)
        {
            return dal.TraerPermisoUsuarioQueNoTieneAsignados(dni);
        }
        /// <summary>
        /// Trae rol usuario.
        /// </summary>
        /// <param name="dni">The dni.</param>
        /// <returns></returns>
        public string TraerRolUsuario(string dni)
        {
            return dal.TraerRolUsuario(dni);
        }
        /// <summary>
        /// Trae usuario para login.
        /// </summary>
        /// <param name="dni">The dni.</param>
        /// <returns></returns>
        public List<Usuario> TraerUsuarioParaLogin(string dni)
        {
            return dal.TraerUsuarioParaLogin(dni);
        }
        /// <summary>
        /// Agrega permiso.
        /// </summary>
        /// <param name="nuevoUsuario">The nuevo usuario.</param>
        /// <param name="dni">The dni.</param>
        public void AgregarPermiso(Usuario nuevoUsuario, string dni)
        {
            dal.AgregarPermiso(nuevoUsuario, dni);
        }
        /// <summary>
        /// Borra usuario.
        /// </summary>
        /// <param name="idUsuario">The identifier usuario.</param>
        /// <returns></returns>
        public int BorrarUsuario(string idUsuario)
        {
            return dal.BorrarUsuario(idUsuario);
        }
        /// <summary>
        /// Traer por nombre.
        /// </summary>
        /// <param name="unNombre">The un nombre.</param>
        /// <returns></returns>
        public List<Usuario> TraerUsuarioPorNombre(string unNombre)
        {
            return dal.TraerUsuarioPorNombre(unNombre);
        }
       

    }
}
