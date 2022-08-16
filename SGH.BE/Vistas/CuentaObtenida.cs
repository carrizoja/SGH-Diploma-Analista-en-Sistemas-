using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE.Vistas
{
    /// <summary>
    /// Clase perteneciente a la Vista Cuenta Obtenida
    /// </summary>
    public class CuentaObtenida
    {
        private int idCuenta;
        private int total;
        private int idHabitacion;
        private Guid idcliente;
        private int idReserva;

        public int IdCuenta { get => idCuenta; set => idCuenta = value; }
        public int Total { get => total; set => total = value; }
        public int IdHabitacion { get => idHabitacion; set => idHabitacion = value; }
        public Guid idCliente { get => idcliente; set => idcliente = value; }
        public int IdReserva { get => idReserva; set => idReserva = value; }
    }
}
