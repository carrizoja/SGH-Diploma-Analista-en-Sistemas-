using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.Servicios
{
    /// <summary>
    /// Interface para serializar
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISerializer<T>
    {
        /// <summary>
        /// Serializes the XML.
        /// </summary>
        /// <param name="objetoASerializar">The objeto a serializar.</param>
        /// <param name="nombreArchivo">The nombre archivo.</param>
        void SerializeXml(T objetoASerializar, string nombreArchivo);
        /// <summary>
        /// Serializes the json.
        /// </summary>
        /// <param name="objetoASerializar">The objeto a serializar.</param>
        /// <param name="nombreArchivo">The nombre archivo.</param>
        void SerializeJson(T objetoASerializar, string nombreArchivo);

    }
}
