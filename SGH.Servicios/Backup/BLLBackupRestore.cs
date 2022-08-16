using SGH.BE;
using SGH.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGH.Servicios;

namespace SGH.BLL
{

    /// <summary>Clase Lógica de Negocio para el Backup - Restore</summary>
    public class BLLBackupRestore
    {
        DALBackupRestore dal = new DALBackupRestore();
        /// <summary>
        /// Graba datos backup.
        /// </summary>
        /// <param name="nombreBaseDeDatos">The nombre base de datos.</param>
        /// <param name="rutaBase">The ruta base.</param>
        /// <param name="nombreBackup">The nombre backup.</param>
        /// <param name="nombreUsuario">The nombre usuario.</param>
        public void GrabarDatosBackup(string nombreBaseDeDatos, string rutaBase, string nombreBackup, string nombreUsuario)
        {
            dal.GrabarDatosBackup(nombreBaseDeDatos, rutaBase, nombreBackup, nombreUsuario);
        }
        /// <summary>
        /// Trae datos backup.
        /// </summary>
        /// <returns></returns>
        public List<Backup> TraerDatosBackup()
        {
            return dal.TraerDatosBackup();
        }
        /// <summary>
        /// Trae bases de datos.
        /// </summary>
        /// <returns></returns>
        public List<String> TraerBasesDeDatos()
        {
            return dal.TraerBasesDeDatos();
        }
        /// <summary>
        /// Hace backup.
        /// </summary>
        /// <param name="nombreBase">The nombre base.</param>
        /// <param name="ruta">The ruta.</param>
        /// <param name="nombreBackup">The nombre backup.</param>
        public void HacerBackup(string nombreBase, string ruta, string nombreBackup)
        {
            dal.HacerBackup(nombreBase, ruta, nombreBackup);
        }
        /// <summary>
        /// Hace restore.
        /// </summary>
        /// <param name="nombreBase">The nombre base.</param>
        /// <param name="ruta">The ruta.</param>
        public void HacerRestore(string nombreBase, string ruta)
        {
            dal.HacerRestore(nombreBase, ruta);
        }
    }
}
