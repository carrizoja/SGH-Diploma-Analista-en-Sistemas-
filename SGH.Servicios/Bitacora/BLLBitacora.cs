using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGH.BE;
using SGH.BE.CompositePermisos;
using SGH.Servicios;


namespace SGH.BLL
{
    /// <summary>
    /// Clase Lógica de Negocio perteneciente a la Bitácora
    /// </summary>
    public class BLLBitacora
    {
        /// <summary>
        /// Graba bitacora.
        /// </summary>
        /// <param name="unaBitacora">The una bitacora.</param>
        public void GrabarBitacora(BE.Bitacora unaBitacora)
        {

            DALBitacora dal = new DALBitacora();
            dal.GrabarBitacora(unaBitacora);

        }
        /// <summary>
        /// Lee bitacora.
        /// </summary>
        /// <param name="unaBitacora">The una bitacora.</param>
        public void LeerBitacora(BE.Bitacora unaBitacora)
        {

            DALBitacora dal = new DALBitacora();
            dal.LeerBitacora(unaBitacora);

        }
        /// <summary>
        /// Trae bitacoras.
        /// </summary>
        /// <returns></returns>
        public List<BE.BitacoraDatos> TraerBitacoras()
        {

            DALBitacora dal = new DALBitacora();
            var datos = dal.TraerBitacoras();
            return datos;
        }
        /// <summary>
        /// Trae formularios bitacora.
        /// </summary>
        /// <returns></returns>
        public List<BE.BitacoraDatos> TraerFormulariosBitacora()
        {
            DALBitacora dal = new DALBitacora();
            var datos = dal.TraerFormulariosBitacora();
            return datos;
        }
        /// <summary>
        /// Trae bitacoras.
        /// </summary>
        /// <param name="unUsuario">The un usuario.</param>
        /// <param name="formulario">The formulario.</param>
        /// <param name="fechaDesde">The fecha desde.</param>
        /// <param name="fechaHasta">The fecha hasta.</param>
        /// <returns></returns>
        public List<BE.BitacoraDatos>TraerBitacoras(Usuario unUsuario, string formulario, DateTime fechaDesde, DateTime fechaHasta)
        {
            DALBitacora dal = new DALBitacora();
            return dal.TraerBitacoras(unUsuario, formulario, fechaDesde, fechaHasta);
        }
        /// <summary>
        /// Trae bitacoras.
        /// </summary>
        /// <param name="formulario">The formulario.</param>
        /// <param name="fechaDesde">The fecha desde.</param>
        /// <param name="fechaHasta">The fecha hasta.</param>
        /// <returns></returns>
        public List<BE.BitacoraDatos> TraerBitacoras(string formulario, DateTime fechaDesde, DateTime fechaHasta)
        {
            DALBitacora dal = new DALBitacora();
            return dal.TraerBitacoras(formulario, fechaDesde, fechaHasta);
        }
        /// <summary>
        /// Trae bitacoras.
        /// </summary>
        /// <param name="fechaDesde">The fecha desde.</param>
        /// <param name="fechaHasta">The fecha hasta.</param>
        /// <returns></returns>
        public List<BE.BitacoraDatos> TraerBitacoras(DateTime fechaDesde, DateTime fechaHasta)
        {
            DALBitacora dal = new DALBitacora();
            return dal.TraerBitacoras(fechaDesde, fechaHasta);
        }
        /// <summary>
        /// Trae bitacoras.
        /// </summary>
        /// <param name="unUsuario">The un usuario.</param>
        /// <param name="fechaDesde">The fecha desde.</param>
        /// <param name="fechaHasta">The fecha hasta.</param>
        /// <returns></returns>
        public List<BE.BitacoraDatos> TraerBitacoras(Usuario unUsuario, DateTime fechaDesde, DateTime fechaHasta)
        {
            DALBitacora dal = new DALBitacora();
            return dal.TraerBitacoras(unUsuario, fechaDesde, fechaHasta);
        }
    }
}
