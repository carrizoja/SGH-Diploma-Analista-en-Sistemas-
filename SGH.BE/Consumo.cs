using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE
{

    /// <summary>Clase de Entidad de Negocio perteneciente a Consumo</summary>
    public class Consumo
    {
        private int idConsumo;
        private Servicio servicio;
        private Habitacion habitacion;
        private Cliente cliente;
        private int precio;
        private string descripcion;
        private Reserva reserva;

        public int IdConsumo { get => idConsumo; set => idConsumo = value; }
        public Servicio Servicio { get => servicio; set => servicio = value; }
        public Habitacion Habitacion { get => habitacion; set => habitacion = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public Reserva Reserva { get => reserva; set => reserva = value; }
    }
}
