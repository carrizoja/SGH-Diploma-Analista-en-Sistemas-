using Framework.Carrizo.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGH.BE;
using SGH.BE.CompositePermisos;
using System.Security.Cryptography;
using Framework.Carrizo.Encriptadores;
using System.Configuration;

namespace SGH.Servicios
{
    /// <summary>
    /// Mapper del Usuario
    /// </summary>
    public class DALUsuario
    {
        /// <summary>
        /// Registra usuario.
        /// </summary>
        /// <param name="nuevoUsuario">The nuevo usuario.</param>
        /// <returns></returns>
        public int RegistrarUsuario(BE.CompositePermisos.Usuario nuevoUsuario)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@IdUsuario", nuevoUsuario.IdUsuario);
                parametros.Add("@Nombre", nuevoUsuario.Nombre);
                parametros.Add("@DNI", nuevoUsuario.Dni);
                parametros.Add("@Email", nuevoUsuario.Email);
                parametros.Add("@Clave", nuevoUsuario.Clave);
                MD5 md5 = MD5.Create();
                string verificadorConcat = Encriptador.RealizarMd5Hash(md5, nuevoUsuario.IdUsuario.ToString() + nuevoUsuario.Nombre.ToString() + nuevoUsuario.Dni.ToString() + nuevoUsuario.Email.ToString() + nuevoUsuario.Clave.ToString());
                nuevoUsuario.DVH = verificadorConcat;
                
                parametros.Add("@DVH", nuevoUsuario.DVH);
                var datosUsuario = unaConexion.EjecutarTupla<Usuario>("Select * from Usuario", new Dictionary<string, object>());

                foreach (var item in datosUsuario)
                {
                    if (item.Dni == nuevoUsuario.Dni)
                    {
                        return 0;
                    }
                    if (item.Email == nuevoUsuario.Email)
                    {
                        return 2;
                    }
                }


                unaConexion.EjecutarSinResultado("insert into Usuario values(@IdUsuario,@Nombre, @DNI, @Email, @Clave, @DVH)", parametros);
                unaConexion.EjecutarSinResultadoDVV("UPDATE DVV SET Dvv = Dvv + 1");
            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();

            }
           
            unaConexion.TransaccionAceptar();
            unaConexion.ConexionFinalizar();
            return 1;
        }
        /// <summary>
        /// Trae todos los usuarios.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Usuario> TraerTodosLosUsuarios()
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                var datosUsuario = unaConexion.EjecutarTupla<Usuario>("Select * from Usuario order by Nombre asc", new Dictionary<string, object>());

                unaConexion.ConexionFinalizar();

                return datosUsuario;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Modifica usuario.
        /// </summary>
        /// <param name="unUsuarioModificado">The un usuario modificado.</param>
        /// <param name="dni">The dni.</param>
        /// <returns></returns>
        public int ModificarUsuario(Usuario unUsuarioModificado, string dni)
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
                parametros.Add("@DniActual", dni);
                parametros.Add("@Dni", unUsuarioModificado.Dni);
                parametros.Add("@Nombre", unUsuarioModificado.Nombre);
                parametros.Add("@Email", unUsuarioModificado.Email);
                unaConexion.EjecutarSinResultado("update Usuario set Dni=@Dni,Nombre=@Nombre,Email=@Email where Dni=@DniActual", parametros);
                
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
        /// Borra usuario.
        /// </summary>
        /// <param name="idUsuario">The identifier usuario.</param>
        /// <returns></returns>
        public int BorrarUsuario(string idUsuario)
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
                parametros.Add("@IdUsuario", idUsuario);
                unaConexion.EjecutarSinResultado("delete from usuario where IdUsuario=@IdUsuario", parametros);
                unaConexion.EjecutarSinResultadoDVV("UPDATE DVV SET Dvv = Dvv - 1");
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
        /// Trae permiso usuario que no tiene asignados.
        /// </summary>
        /// <param name="dni">The dni.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Patente> TraerPermisoUsuarioQueNoTieneAsignados(string dni)
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

                var datosUsuario = unaConexion.EjecutarTupla<BE.CompositePermisos.Patente>("SELECT * FROM PERMISO PPP WHERE PPP.IDPERMISO NOT IN(SELECT PP.IdPermiso AS IdPermiso FROM USUARIO US join USUARIO_PERMISO UP ON US.IdUsuario = UP.IdUsuario join PERMISO P ON UP.IdPermiso = P.IdPermiso join PermisoFamilia PF ON P.IdPermiso = PF.IdFamilia join Permiso PP ON PP.IdPermiso = PF.IdPermiso where US.Dni  = @DNI) AND PPP.IDPERMISO NOT IN(SELECT P.IdPermiso AS IdPermiso FROM USUARIO US join USUARIO_PERMISO UP ON US.IdUsuario = UP.IdUsuario join PERMISO P ON UP.IdPermiso = P.IdPermiso where US.Dni  = @DNI and p.nombre not in ('Gerente', 'Administrador', 'Vendedor', 'Jefe', 'Asistente')) AND PPP.NOMBRE NOT IN ('Gerente','Administrador','Vendedor','Jefe','Asistente')", parametros);

                unaConexion.ConexionFinalizar();

                return datosUsuario;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Agrega permiso.
        /// </summary>
        /// <param name="nuevoUsuario">The nuevo usuario.</param>
        /// <param name="dni">The dni.</param>
        public void AgregarPermiso(Usuario nuevoUsuario, string dni)
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

                var idUsuario = unaConexion.EjecutarEscalar("select IdUsuario from Usuario where Dni=@DNI", parametros);

                Dictionary<string, object> idUser = new Dictionary<string, object>();
                idUser.Add("@IdUsuario", idUsuario);
                unaConexion.EjecutarSinResultado("delete from Usuario_Permiso where IdUsuario=@IdUsuario", idUser);

                foreach (Familia i in nuevoUsuario.Permisos)
                {
                    if (i.GetType().Name == "Familia" && i.accesos.Count() != 1 && i.Nombre != null)
                    {
                        Dictionary<string, object> parametroPermiso = new Dictionary<string, object>();

                        parametroPermiso.Add("@IdUsuario", idUsuario);
                        parametroPermiso.Add("@IdPermiso", i.IdPermiso);

                        unaConexion.EjecutarSinResultado("insert into Usuario_Permiso values(@IdUsuario,@IdPermiso)", parametroPermiso);


                        if (i.CantidadHijos() > 0)
                        {
                            foreach (Patente _leaf in i.accesos)
                            {
                                //alf begin
                                if (_leaf.IdPermiso.ToString() == "00000000-0000-0000-0000-000000000000")
                                {
                                    _leaf.Nombre = _leaf.Nombre;
                                }
                                //alf end

                                Dictionary<string, object> parametroLeaf = new Dictionary<string, object>();

                                parametroLeaf.Add("@IdUsuario", idUsuario);
                                parametroLeaf.Add("@IdPermiso", _leaf.IdPermiso);

                                unaConexion.EjecutarSinResultado("Insert into Usuario_Permiso values(@IdUsuario,@IdPermiso)", parametroLeaf);


                            }
                        }
                    }
                    else
                    {
                        foreach (Patente _leaf in i.accesos)
                        {

                            Dictionary<string, object> parametroLeaf = new Dictionary<string, object>();

                            parametroLeaf.Add("@IdUsuario", idUsuario);
                            parametroLeaf.Add("@IdPermiso", _leaf.IdPermiso);

                            unaConexion.EjecutarSinResultado("Insert into Usuario_Permiso values(@IdUsuario,@IdPermiso)", parametroLeaf);

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();

            }

            unaConexion.TransaccionAceptar();
            unaConexion.ConexionFinalizar();
        }
        /// <summary>
        /// Trae permiso usuario.
        /// </summary>
        /// <param name="dni">The dni.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Patente> TraerPermisoUsuario(string dni)
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

                var datosUsuario = unaConexion.EjecutarTupla<BE.CompositePermisos.Patente>("SELECT PP.IdPermiso AS IdPermiso,PP.NOMBRE AS Nombre FROM USUARIO US join USUARIO_PERMISO UP ON US.IdUsuario = UP.IdUsuario join PERMISO P ON UP.IdPermiso = P.IdPermiso join PermisoFamilia PF ON P.IdPermiso = PF.IdFamilia join Permiso PP ON PP.IdPermiso = PF.IdPermiso where US.Dni = @DNI union SELECT P.IdPermiso AS IdPermiso, P.NOMBRE AS Nombre FROM USUARIO US join USUARIO_PERMISO UP ON US.IdUsuario = UP.IdUsuario join PERMISO P ON UP.IdPermiso = P.IdPermiso where US.Dni = @DNI and p.nombre not in ('Gerente', 'Administrador', 'Vendedor', 'Jefe', 'Asistente')", parametros);
                unaConexion.ConexionFinalizar();

                return datosUsuario;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Trae rol usuario.
        /// </summary>
        /// <param name="dni">The dni.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string TraerRolUsuario(string dni)
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


                var datosUsuario = unaConexion.EjecutarTupla<BE.CompositePermisos.Familia>("SELECT TOP 1 P.NOMBRE AS Nombre FROM USUARIO US join USUARIO_PERMISO UP ON US.IdUsuario = UP.IdUsuario join PERMISO P ON UP.IdPermiso = P.IdPermiso join PermisoFamilia PF ON P.IdPermiso = PF.IdFamilia join Permiso PP ON PP.IdPermiso = PF.IdPermiso where US.Dni=@DNI", parametros);

                string rolUsuario;

                if (datosUsuario.Count > 0)
                {
                    rolUsuario = datosUsuario[0].Nombre;

                    unaConexion.ConexionFinalizar();

                    return rolUsuario;
                }
                else
                {
                    return "Ninguno";
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Trae usuario para login.
        /// </summary>
        /// <param name="dni">The dni.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Usuario> TraerUsuarioParaLogin(string dni)
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

                var datosUsuario = unaConexion.EjecutarTupla<BE.CompositePermisos.Usuario>("Select * from Usuario where DNI=@DNI", parametros);

                unaConexion.ConexionFinalizar();

                return datosUsuario;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Trae permiso simples por dni.
        /// </summary>
        /// <param name="dni">The dni.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Familia> TraerPermisoSimplesPorDni(string dni)
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

                var datosUsuario = unaConexion.EjecutarTupla<BE.CompositePermisos.Familia>("select pe.IdPermiso,pe.Nombre from usuario us join Usuario_Permiso up on us.IdUsuario = up.IdUsuario join Permiso pe on up.IdPermiso = pe.IdPermiso where us.Dni = @DNI", parametros);

                unaConexion.ConexionFinalizar();

                return datosUsuario;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Agrega rol.
        /// </summary>
        /// <param name="nuevoUsuario">The nuevo usuario.</param>
        /// <param name="dni">The dni.</param>
        public void AgregarRol(Usuario nuevoUsuario, string dni)
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

                var idUsuario = unaConexion.EjecutarEscalar("select IdUsuario from Usuario where Dni=@DNI", parametros);

                Dictionary<string, object> idUser = new Dictionary<string, object>();
                idUser.Add("@IdUsuario", idUsuario);
                unaConexion.EjecutarSinResultado("delete from Usuario_Permiso where IdUsuario=@IdUsuario", idUser);

                foreach (Familia i in nuevoUsuario.Permisos)
                {
                    if (i.GetType().Name == "Familia")
                    {
                        Dictionary<string, object> parametroPermiso = new Dictionary<string, object>();

                        parametroPermiso.Add("@IdUsuario", idUsuario);
                        parametroPermiso.Add("@IdPermiso", i.IdPermiso);

                        unaConexion.EjecutarSinResultado("insert into Usuario_Permiso values(@IdUsuario,@IdPermiso)", parametroPermiso);

                        if (i.CantidadHijos() > 0)
                        {
                            foreach (Patente _leaf in i.accesos)
                            {

                                Dictionary<string, object> parametroLeaf = new Dictionary<string, object>();

                                parametroLeaf.Add("@IdUsuario", idUsuario);
                                parametroLeaf.Add("@IdPermiso", _leaf.IdPermiso);

                                unaConexion.EjecutarSinResultado("Insert into Usuario_Permiso values(@IdUsuario,@IdPermiso)", parametroLeaf);


                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();

            }

            unaConexion.TransaccionAceptar();
            unaConexion.ConexionFinalizar();
        }
        /// <summary>
        /// Trae permiso simples.
        /// </summary>
        /// <param name="idSelected">The identifier selected.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Patente> TraerPermisoSimples(string idSelected)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@IdPermiso", idSelected);

                var datosUsuario = unaConexion.EjecutarTupla<BE.CompositePermisos.Patente>("SELECT PP.IdPermiso,PP.NOMBRE AS Nombre FROM  PERMISO P join PermisoFamilia PF ON P.IdPermiso = PF.IdFamilia join Permiso PP ON PP.IdPermiso = PF.IdPermiso where P.IdPermiso = @IdPermiso;", parametros);

                unaConexion.ConexionFinalizar();

                return datosUsuario;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }

        /// <summary>
        /// Trae roles para agregar.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Familia> TraerRolesParaAgregar()
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                var datosUsuario = unaConexion.EjecutarTupla<BE.CompositePermisos.Familia>("Select IdPermiso,Nombre from Permiso where nombre in('Administrador','Recepcionista','Supervisor','Gerente','Ama de Llaves');", new Dictionary<string, object>());

                unaConexion.ConexionFinalizar();

                return datosUsuario;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Trae usuario.
        /// </summary>
        /// <param name="dni">The dni.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string TraerUsuario(string dni)
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


                var datosUsuario = unaConexion.EjecutarTupla<BE.CompositePermisos.Usuario>("Select * from Usuario where DNI=@DNI", parametros);


                unaConexion.ConexionFinalizar();

                if (datosUsuario.Count != 0)
                {
                    string nombreUsuario;
                    nombreUsuario = datosUsuario[0].Nombre;
                    return nombreUsuario;
                }
                else
                {
                    return "NO";
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Inicia sesion.
        /// </summary>
        /// <param name="usuario">The usuario.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool IniciarSesion(BE.CompositePermisos.Usuario usuario)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@DNI", usuario.Dni);
                parametros.Add("@Clave", usuario.Clave);

                var datosUsuario = unaConexion.EjecutarTupla<BE.CompositePermisos.Usuario>("Select * from Usuario where DNI=@DNI", parametros);
                bool clave;

                if (datosUsuario.Count == 1)
                {
                    MD5 md5 = MD5.Create();
                    return clave = Framework.Carrizo.Encriptadores.Encriptador.VerificarMd5Hash(md5, usuario.Clave, datosUsuario[0].Clave);
                }
                else
                {
                    unaConexion.ConexionFinalizar();
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }

        }
        /// <summary>
        /// Trae usuario por nombre.
        /// </summary>
        /// <param name="nombre">The nombre.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Usuario> TraerUsuarioPorNombre(string nombre)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@Nombre", nombre);

                var datosUsuario = unaConexion.EjecutarTupla<BE.CompositePermisos.Usuario>("Select * from Usuario where Nombre=@Nombre", parametros);

                unaConexion.ConexionFinalizar();

                return datosUsuario;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }

    }
}
