using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE
{
    /// <summary>
    /// Clase de Entidad de Negocio perteneciente a Cliente
    /// </summary>
    public class Cliente
    {
       
        public Guid idCliente { get; set; }
        public string Nombre { get; set; }
        public String Apellido { get; set; }
        public int Dni { get; set; }
        public int Edad { get; set; }
        public String Email { get; set; }
        public int Telefono { get; set; }     
     
    }
}
