using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGH.BE;
using SGH.BE.Vistas;

namespace SGH.BLL
{
    /// <summary>
    /// Clase Lógica de Negocio de Cuenta
    /// </summary>
    public class BLLCuenta
    {
       
        private DAL.DALCuenta cuentaDAL = new DAL.DALCuenta();
        public int CrearCuenta(Reserva unaReserva, Cuenta cuenta)
        {
            return cuentaDAL.CrearCuenta(unaReserva, cuenta);
        }

        /// <summary>
        /// Obtener cuenta.
        /// </summary>
        /// <param name="reserva">The reserva.</param>
        /// <returns></returns>
        public List<CuentaObtenida> ObtenerCuenta(Reserva reserva)
       {
            return cuentaDAL.ObtenerCuenta(reserva);
       }

        /// <summary>
        /// Obtener cuenta final.
        /// </summary>
        /// <param name="apellido">The apellido.</param>
        /// <param name="numeroHab">The numero hab.</param>
        /// <returns></returns>
        public List<CuentaObtenida> ObtenerCuentaFinal(string apellido, string numeroHab)
        {
            return cuentaDAL.ObtenerCuentaFinal(apellido, numeroHab);
        }

        /// <summary>
        /// Cargar consumo cuenta.
        /// </summary>
        /// <param name="unaCuenta">The una cuenta.</param>
        /// <returns></returns>
        public int CargarConsumoCuenta (Cuenta unaCuenta)
        {
            return cuentaDAL.CargarConsumoCuenta(unaCuenta);
        }

        /// <summary>
        /// Cerrar cuenta.
        /// </summary>
        /// <param name="idCuenta">The identifier cuenta.</param>
        /// <returns></returns>
        public int CerrarCuenta(int idCuenta)
        {
            return cuentaDAL.CerrarCuenta(idCuenta);
        }

    }

  
}
