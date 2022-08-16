using SGH.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BLL
{
    /// <summary>
    /// Clade de Lógica de Negocio perteneciente a Consumo
    /// </summary>
    public class BLLConsumo
    {
        
        private DAL.DALConsumo consumoDAL = new DAL.DALConsumo();

        /// <summary>
        /// Carga consumo.
        /// </summary>
        /// <param name="consumo">The consumo.</param>
        /// <returns></returns>
        public int CargarConsumo(Consumo consumo)
        {
            return consumoDAL.CargarConsumo(consumo);
        }

        /// <summary>
        /// Lista consumos por habitacion.
        /// </summary>
        /// <param name="numero">The numero.</param>
        /// <returns></returns>
        public List<SGH.BE.Vistas.ListaDeConsumosVista> ListarConsumosPorHabitacion(string numero)
        {
            return consumoDAL.ListarConsumosPorHabitacion(numero);
        }
        /// <summary>
        /// Cierra consumos.
        /// </summary>
        /// <param name="cuenta">The cuenta.</param>
        /// <returns></returns>
        public int CerrarConsumos(Cuenta cuenta)
        {
            return consumoDAL.CerrarConsumos(cuenta);
        }

    }
}

