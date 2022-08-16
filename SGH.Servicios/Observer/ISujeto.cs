using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE.Observer
{
    /// <summary>
    /// Interfaz ISujeto que registra, notifica y saca registro del patrón Observer
    /// </summary>
    public interface ISujeto
    {
        void RegistrarObserver(IObserver observer);
        void SacarRegistroObserver(IObserver observer);
        void NotificarObservers();


    }
}
