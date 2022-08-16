using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE.Vistas
{
    /// <summary>
    /// Vista de un Room Service
    /// </summary>
    public class RoomServiceVista
    {
        private int idRoomService;
        private string descripcion;
        private int precio;
        private string disponibilidad;

        public int IdRoomService { get => idRoomService; set => idRoomService = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Disponibilidad { get => disponibilidad; set => disponibilidad = value; }
    }
}
