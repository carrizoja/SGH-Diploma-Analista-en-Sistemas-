using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.Servicios
{
    /// <summary>
    /// Clase utilizada para pasar la cadena de conexión
    /// </summary>
    public class Configuracion
    {
        /// <summary>
        /// Obtiene el conexion SQL server.
        /// </summary>
        /// <returns></returns>
        public static string ObtenerStringConexionSqlServer()
        {
            return "Data Source=KOCHE-PC;Initial Catalog=SGH;Integrated Security=True";
        }
        /// <summary>
        /// Obtiene el string conexion SQL server para backup restore.
        /// </summary>
        /// <returns></returns>
        public static string ObtenerStringConexionSqlServerParaBackupRestore()
        {
            return "Data Source=KOCHE-PC;Initial Catalog=master;Integrated Security=True";
        }


    }
}
