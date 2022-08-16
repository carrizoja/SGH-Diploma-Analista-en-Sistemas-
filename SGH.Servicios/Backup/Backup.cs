using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE

      
{
    /// <summary>
    /// Clase Entidad de Negocio de Backup
    /// </summary>
    public class Backup
    {
        public Guid IdBackup { get; set; }
        public string NombreBase { get; set; }
        public string NombreBackup { get; set; }
        public string Ruta { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; } 
    }
}
