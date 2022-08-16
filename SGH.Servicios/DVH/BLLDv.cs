using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGH.DAL;
using SGH.BE.CompositePermisos;
using Framework.Carrizo.Encriptadores;
using System.Security.Cryptography;
using SGH.Servicios;

namespace SGH.BLL
{
    /// <summary>
    /// Clase Lógica de Negocio del DVH
    /// </summary>
    public class BLLDv
    { 
        DALDv dal = new DALDv();

        /// <summary>
        /// Calcula  digito verificador horizontal usuario.
        /// </summary>
        /// <param name="usuario">The usuario.</param>
        /// <returns></returns>
        public bool CalcularDigitoVerificadorHorizontalUsuario(Usuario usuario)
        {
            MD5 md5 = MD5.Create();
            string verificadorConcat = Encriptador.RealizarMd5Hash(md5,usuario.IdUsuario.ToString() + usuario.Nombre.ToString() + usuario.Dni.ToString() + usuario.Email.ToString() + usuario.Clave.ToString());
            if (verificadorConcat == usuario.DVH)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Calcula digito verificador vertical.
        /// </summary>
        /// <returns></returns>
        public bool CalcularDigitoVerificadorVertical()
        {
        return dal.CalcularDigitoVerificadorVertical();
        }

    }
}

