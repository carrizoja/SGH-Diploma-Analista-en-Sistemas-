using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE
{
    /// <summary>
    /// Clase de Entidad de negocio perteneciente a Room Service
    /// </summary>
    /// <seealso cref="SGH.BE.Servicio" />
    public class RoomService: BE.Servicio
    {
        private int idRoomService;
        private bool esbebida;

        public int IdRoomService { get => idRoomService; set => idRoomService = value; }
        public bool Esbebida { get => esbebida; set => esbebida = value; }
    }


}
