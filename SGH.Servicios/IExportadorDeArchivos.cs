using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.Servicios
{
    /// <summary>
    /// Interface para exportar archivos
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IExportadorDeArchivos<T>
    {
        /// <summary>
        /// Exporta archivo.
        /// </summary>
        /// <param name="TablaExportar">The tabla exportar.</param>
        /// <param name="nombreArchivo">The nombre archivo.</param>
        void ExportarArchivo(T TablaExportar, string nombreArchivo);


    }
}
