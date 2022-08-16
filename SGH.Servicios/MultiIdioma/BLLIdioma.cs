using SGH.BE.MultiIdioma;
using SGH.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGH.BE;
using System.Drawing;
using SGH.Servicios;


namespace SGH.BLL
{
    /// <summary>
    /// Clase Lógica de Negocio para Idioma
    /// </summary>
    public class BLLIdioma
    {
        private DALIdioma dal = new DALIdioma();
        /// <summary>
        /// Traer controles.
        /// </summary>
        /// <param name="idioma">The idioma.</param>
        /// <returns></returns>
        public List<ControlIdioma> TraerControles(int idioma)
        {
            DALIdioma controles = new DALIdioma();
            List<ControlIdioma> resultado = controles.TraerControles(idioma);
            return resultado;
        }

        /// <summary>
        /// Traducir ID idioma.
        /// </summary>
        /// <param name="idIdioma">The identifier idioma.</param>
        /// <param name="formTraducir">The form traducir.</param>
        public void Traducir(int idIdioma, Form formTraducir)
        {
            if (idIdioma == 1)
            {
                BLLIdioma cambiarIdioma = new BLLIdioma();
                var idiomaEspanol = cambiarIdioma.TraerControles(1);
                SGH.Servicios.Traductor.CambiarIdioma(formTraducir, idiomaEspanol);
            }
            if (idIdioma == 2)
            {
                BLLIdioma cambiarIdioma = new BLLIdioma();
                var idiomaIngles = cambiarIdioma.TraerControles(2);
                SGH.Servicios.Traductor.CambiarIdioma(formTraducir, idiomaIngles);
            }
        }
        /// <summary>
        /// Traer todos los idiomas.
        /// </summary>
        /// <returns></returns>
        public List<SGH.BE.MultiIdioma.Idioma> TraerTodosLosIdiomas()
        {
            return dal.TraerTodosLosIdiomas();
        }
        /// <summary>
        /// Traer idioma seleccionado.
        /// </summary>
        /// <param name="idiomaSeleccionado">The idioma seleccionado.</param>
        /// <returns></returns>
        public List<SGH.BE.MultiIdioma.Idioma> TraerIdiomaSeleccionado(String idiomaSeleccionado)
        {
            return dal.TraerIdiomaSeleccionado(idiomaSeleccionado);
        }
        /// <summary>
        /// Agregar idioma.
        /// </summary>
        /// <param name="unIdioma">The un idioma.</param>
        /// <returns></returns>
        public int AgregarIdioma(SGH.BE.MultiIdioma.Idioma unIdioma)
        {
            return dal.AgregarIdioma(unIdioma);
        }
        /// <summary>
        /// Obtener traducciones idioma.
        /// </summary>
        /// <param name="idIdioma">The identifier idioma.</param>
        /// <returns></returns>
        public List<Traduccion> ObtenerTraduccionesIdioma(int idIdioma)
        {
            return dal.ObtenerTraduccionesIdioma(idIdioma);
        }
        /// <summary>
        /// Traer todas las palabras.
        /// </summary>
        /// <returns></returns>
        public List<Palabra> TraerTodasLasPalabras()
        {
            return dal.TraerTodasLasPalabras();
        }
        /// <summary>
        /// Cargar traduccion.
        /// </summary>
        /// <param name="unaTraduccion">The una traduccion.</param>
        /// <returns></returns>
        public int CargarTraduccion(Traduccion unaTraduccion)
        {
            return dal.CargarTraduccion(unaTraduccion);
        }
        /// <summary>
        /// Modificar traduccion.
        /// </summary>
        /// <param name="unaTraduccion">The una traduccion.</param>
        /// <returns></returns>
        public int ModificarTraduccion(Traduccion unaTraduccion)
        {
            return dal.ModificarTraduccion(unaTraduccion);
        }
        /// <summary>
        /// Eliminar traduccion.
        /// </summary>
        /// <param name="unaTraduccion">The una traduccion.</param>
        /// <returns></returns>
        public int EliminarTraduccion(Traduccion unaTraduccion)
        {
            return dal.EliminarTraduccion(unaTraduccion);
        }
        /// <summary>
        /// Eliminar idioma.
        /// </summary>
        /// <param name="idioma">The idioma.</param>
        /// <returns></returns>
        public int EliminarIdioma(SGH.BE.MultiIdioma.Idioma idioma)
        {
            return dal.EliminarIdioma(idioma);
        }
        /// <summary>
        /// Cargar palabra.
        /// </summary>
        /// <param name="unaPalabra">The una palabra.</param>
        /// <returns></returns>
        public int CargarPalabra(Palabra unaPalabra)
        {
            return dal.CargarPalabra(unaPalabra);
        }
        /// <summary>
        /// Eliminar palabra.
        /// </summary>
        /// <param name="unaPalabra">The una palabra.</param>
        /// <returns></returns>
        public int EliminarPalabra(Palabra unaPalabra)
        {
            return dal.EliminarPalabra(unaPalabra);
        }
        /// <summary>
        /// Modificar palabra.
        /// </summary>
        /// <param name="unaPalabra">The una palabra.</param>
        /// <returns></returns>
        public int ModificarPalabra(Palabra unaPalabra)
        {
            return dal.ModificarPalabra(unaPalabra);
        }

    }
}
