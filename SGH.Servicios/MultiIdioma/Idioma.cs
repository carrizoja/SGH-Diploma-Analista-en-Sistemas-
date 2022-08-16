using SGH.BE.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE.MultiIdioma
{
    /// <summary>
    /// Clase Entidad de Negocio que implementa la interface ISujeto
    /// </summary>
    /// <seealso cref="SGH.BE.Observer.ISujeto" />
    public class Idioma : ISujeto

    {
        public int IdIdioma { get; set; }
        public String Nombre { get; set; }

        private static Idioma instanciaIdioma = null;
        /// <summary>
        /// Gets the instancia idioma.
        /// </summary>
        /// <value>
        /// The instancia idioma.
        /// </value>
        public static Idioma InstanciaIdioma
        {
            get { if (instanciaIdioma == null)
                    instanciaIdioma = new Idioma();
                return instanciaIdioma;

            }
        }
        /// <summary>
        /// Destructors this instance.
        /// </summary>
        public static void Destructor()
        {
            instanciaIdioma = null;
        }

        private List<IObserver> observers;
        /// <summary>
        /// Initializes a new instance of the <see cref="Idioma"/> class.
        /// </summary>
        public Idioma()
        {
            observers = new List<IObserver>();

        }

        public void NotificarObservers()
        {
            foreach (IObserver ob in observers)

                ob.Actualizar();
        }
        /// <summary>
        /// Registrars the observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        public void RegistrarObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        /// <summary>
        /// Sacars the registro observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        public void SacarRegistroObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

      
    }
}
