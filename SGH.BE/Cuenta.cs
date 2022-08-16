using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE
{

    /// <summary>
    /// Clase de Entidad de Negocio perteneciente a Cuenta
    /// </summary>
    public class Cuenta
    {


        private int idCuenta;
        private DateTime fechaCreacion;
        private DateTime fechaCierre;
        private Cliente cliente;
        private Habitacion habitacion;
        private int total;
        private bool activa;
        private Reserva reserva;

                 

        public int IdCuenta { get => idCuenta; set => idCuenta = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public DateTime FechaCierre { get => fechaCierre; set => fechaCierre = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Habitacion Habitacion { get => habitacion; set => habitacion = value; }
        public int Total { get => total; set => total = value; }
        public bool Activa { get => activa; set => activa = value; }
        public Reserva Reserva { get => reserva; set => reserva = value; }
    }
}
