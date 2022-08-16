using Framework.Carrizo.Persistencia;
using SGH.BE.MultiIdioma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGH.BE;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace SGH.Servicios
{
    /// <summary>
    /// Mapper para el Idioma
    /// </summary>
    public class DALIdioma
    {
        /// <summary>
        /// Agregar idioma.
        /// </summary>
        /// <param name="unIdioma">The un idioma.</param>
        /// <returns></returns>
        public int AgregarIdioma(SGH.BE.MultiIdioma.Idioma unIdioma)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
          //  string conexion = ConfigurationManager.AppSettings["SGHConnection"];

            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@Nombre", unIdioma.Nombre);
               

                var idiomasEnBase = unaConexion.EjecutarTupla<BE.MultiIdioma.Idioma>("Select * from Idioma ", parametros);

                foreach (var idiomaBase in idiomasEnBase)
                {
                    if (idiomaBase.Nombre == unIdioma.Nombre)
                    {
                        return 0;
                    }
                  
                }

                unaConexion.EjecutarSinResultado("insert into Idioma values(@Nombre)", parametros);



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
        /// Trae controles.
        /// </summary>
        /// <param name="idioma">The idioma.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<ControlIdioma> TraerControles(int idioma)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@IdIdioma", idioma);


                var datosUsuario = unaConexion.EjecutarTupla<ControlIdioma>("select p.Descripcion as NombreOriginal,t.Descripcion  as NombreTraducido from palabra p join Traduccion t on p.IdPalabra = t.IdPalabra  where t.IdIdioma = @IdIdioma;", parametros);


                unaConexion.ConexionFinalizar();


                return datosUsuario;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }

        /// <summary>
        /// Traer todos los idiomas.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<BE.MultiIdioma.Idioma> TraerTodosLosIdiomas()
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
          //  string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                var datosIdioma = unaConexion.EjecutarTupla<BE.MultiIdioma.Idioma>("Select * FROM IDIOMA", new Dictionary<string, object>());

                unaConexion.ConexionFinalizar();

                return datosIdioma;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
           
        }
        /// <summary>
        /// Traer idioma seleccionado.
        /// </summary>
        /// <param name="idiomaSeleccionado">The idioma seleccionado.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<SGH.BE.MultiIdioma.Idioma> TraerIdiomaSeleccionado(string idiomaSeleccionado)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@Nombre", idiomaSeleccionado);

                var datosIdioma = unaConexion.EjecutarTupla<SGH.BE.MultiIdioma.Idioma>("Select * from Idioma where Nombre=@Nombre", parametros);

                unaConexion.ConexionFinalizar();

                return datosIdioma;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }

        }
        /// <summary>
        /// Obtener traducciones idioma.
        /// </summary>
        /// <param name="idIdioma">The identifier idioma.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Traduccion> ObtenerTraduccionesIdioma(int idIdioma)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@IdIdioma", idIdioma);
               

                var datosTraduccion = unaConexion.EjecutarTupla<Traduccion>("select * from Traduccion where IdIdioma=@IdIdioma order by Descripcion asc", parametros);

                unaConexion.ConexionFinalizar();

                return datosTraduccion;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Traer todas las palabras.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Palabra> TraerTodasLasPalabras()
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                var datosPalabra = unaConexion.EjecutarTupla<BE.MultiIdioma.Palabra>("Select * FROM PALABRA order by Descripcion asc", new Dictionary<string, object>());

                unaConexion.ConexionFinalizar();

                return datosPalabra;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Cargar traduccion.
        /// </summary>
        /// <param name="unaTraduccion">The una traduccion.</param>
        /// <returns></returns>
        public int CargarTraduccion(Traduccion unaTraduccion)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@IdPalabra", unaTraduccion.IdPalabra);
                parametros.Add("@Descripcion", unaTraduccion.Descripcion);
                parametros.Add("@IdIdioma", unaTraduccion.IdIdioma);
            
                var traduccionesEnBase = unaConexion.EjecutarTupla<Traduccion>("Select * from Traduccion where IdIdioma = @IdIdioma", parametros);

                foreach (var traduccionBase in traduccionesEnBase)
                {
                    if (traduccionBase.Descripcion == unaTraduccion.Descripcion)
                    {
                        return 0;
                    }

                }

                unaConexion.EjecutarSinResultado("insert into Traduccion values (@IdIdioma, @IdPalabra, @Descripcion)", parametros);



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
        /// Modificar traduccion.
        /// </summary>
        /// <param name="unaTraduccion">The una traduccion.</param>
        /// <returns></returns>
        public int ModificarTraduccion(Traduccion unaTraduccion)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@IdPalabra", unaTraduccion.IdPalabra);
                parametros.Add("@Descripcion", unaTraduccion.Descripcion);
                parametros.Add("@IdIdioma", unaTraduccion.IdIdioma);
               
                unaConexion.EjecutarSinResultado("update Traduccion set Descripcion=@Descripcion where @IdPalabra=IdPalabra AND @IdIdioma=IdIdioma", parametros);



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
        /// Eliminar traduccion.
        /// </summary>
        /// <param name="unaTraduccion">The una traduccion.</param>
        /// <returns></returns>
        public int EliminarTraduccion(Traduccion unaTraduccion)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
           
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
               
                parametros.Add("@IdPalabra", unaTraduccion.IdPalabra);
                parametros.Add("@IdIdioma", unaTraduccion.IdIdioma);
                unaConexion.EjecutarSinResultado("delete from Traduccion where IdPalabra=@IdPalabra AND IdIdioma=@IdIdioma", parametros);


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
        /// Eliminar idioma.
        /// </summary>
        /// <param name="unIdioma">The un idioma.</param>
        /// <returns></returns>
        public int EliminarIdioma(SGH.BE.MultiIdioma.Idioma unIdioma)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();

            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();

               
                parametros.Add("@IdIdioma", unIdioma.IdIdioma);
                unaConexion.EjecutarSinResultado("delete from Idioma where IdIdioma=@IdIdioma", parametros);


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
        /// Cargar palabra.
        /// </summary>
        /// <param name="unaPalabra">The una palabra.</param>
        /// <returns></returns>
        public int CargarPalabra(Palabra unaPalabra)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
          //  string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                
                parametros.Add("@Descripcion", unaPalabra.Descripcion);
                
                var palabrasEnBase = unaConexion.EjecutarTupla<Palabra>("Select * from Palabra ", parametros);

                foreach (var palabraBase in palabrasEnBase)
                {
                    if (palabraBase.Descripcion == unaPalabra.Descripcion)
                    {
                        return 0;
                    }

                }

                unaConexion.EjecutarSinResultado("insert into Palabra values (NEWID(),@Descripcion)", parametros);



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
        /// Eliminar palabra.
        /// </summary>
        /// <param name="unaPalabra">The una palabra.</param>
        /// <returns></returns>
        public int EliminarPalabra(Palabra unaPalabra)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();

            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();

                parametros.Add("@IdPalabra", unaPalabra.IdPalabra);
               
                unaConexion.EjecutarSinResultado("delete from Palabra where IdPalabra=@IdPalabra", parametros);


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
        /// Modificar palabra.
        /// </summary>
        /// <param name="unaPalabra">The una palabra.</param>
        /// <returns></returns>
        public int ModificarPalabra(Palabra unaPalabra)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@IdPalabra", unaPalabra.IdPalabra);
                parametros.Add("@Descripcion", unaPalabra.Descripcion);
                

                unaConexion.EjecutarSinResultado("update Palabra set Descripcion=@Descripcion where @IdPalabra=IdPalabra ", parametros);



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
