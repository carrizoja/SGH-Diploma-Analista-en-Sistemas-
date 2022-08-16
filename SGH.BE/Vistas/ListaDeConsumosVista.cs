using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE.Vistas
{
    /// <summary>
    /// Vista que muestra todos los consumos
    /// </summary>
    public class ListaDeConsumosVista
    {
        private string descripcion;
        private int precio;
        private string nombre;
        private string apellido;
        private DateTime fechaDePedido;

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaDePedido { get => fechaDePedido; set => fechaDePedido = value; }
    }
}
