using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE.CompositePermisos
{
    /// <summary>
    /// Clase de Entidad de Negocio perteneciente al Usuario
    /// </summary>
    public class Usuario
    {
        public Guid IdUsuario { get; set; }
        public string Nombre { get; set; }
        public String Dni { get; set; }
        public String Email { get; set; }
        public string Clave { get; set; }
        public List<Familia> Permisos = new List<Familia>();

        private static Usuario instancia = null;

        /// <summary>
        /// Obtiene la instancia.
        /// </summary>
        /// <value>
        /// The instancia.
        /// </value>
        public static Usuario Instancia
        {
            get { if (instancia == null)
                    instancia = new Usuario();
                return instancia;
            }

        }
        /// <summary>
        /// Destructor de esta instancia.
        /// </summary>
        public static void Destructor()
        {

            instancia = null;
        }

        private bool _errorDigito;
        /// <summary>
        /// Gets or sets a value indicating whether [error digito].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [error digito]; otherwise, <c>false</c>.
        /// </value>
        public bool errorDigito
        {
            get { return _errorDigito; }
            set { _errorDigito = value; }
        }

        private BE.MultiIdioma.Idioma _idioma;
        /// <summary>
        /// Obtiene idioma.
        /// </summary>
        /// <value>
        /// The idioma.
        /// </value>
        public BE.MultiIdioma.Idioma idioma
        {
            get { return _idioma; }
            set { _idioma = value; }
        }

        private bool _bloqueado;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Usuario"/> is bloqueado.
        /// </summary>
        /// <value>
        ///   <c>true</c> if bloqueado; otherwise, <c>false</c>.
        /// </value>
        public bool bloqueado
        {
            get { return _bloqueado; }
            set { _bloqueado = value; }
        }

        private int _intentosFallidos;
        /// <summary>
        /// Gets or sets the intentos fallidos.
        /// </summary>
        /// <value>
        /// The intentos fallidos.
        /// </value>
        public int intentosFallidos
        {
            get { return _intentosFallidos; }
            set { _intentosFallidos = value; }
        }

        private bool _borrado;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Usuario"/> is borrado.
        /// </summary>
        /// <value>
        ///   <c>true</c> if borrado; otherwise, <c>false</c>.
        /// </value>
        public bool borrado
        {
            get { return _borrado; }
            set { _borrado = value; }
        }

        private string _dvh;
        /// <summary>
        /// Gets or sets the DVH.
        /// </summary>
        /// <value>
        /// The DVH.
        /// </value>
        public String DVH
        {
            get { return _dvh; }
            set { _dvh = value; }
        }
            

        //private Perfil _perfil;
        //public Perfil perfil
        //{
        //    get { return _perfil; }
        //    set { _perfil = value; }
        //}
    }
}
