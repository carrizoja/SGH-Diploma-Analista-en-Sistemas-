using Framework.Carrizo.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGH.BE;
using System.Configuration;

namespace SGH.Servicios
{
    /// <summary>
    /// Mapper para el Dígito Verificador Horizonal
    /// </summary>
    public class DALDv
    {
        /// <summary>
        /// Calcula digito verificador vertical.
        /// </summary>
        /// <returns></returns>
        public bool CalcularDigitoVerificadorVertical()
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
           // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();



                var cantidadRegistrosTablaUsuario = unaConexion.EjecutarTupla<DigitoVerificadorVertical>("select count(*) as Dvv from Usuario", new Dictionary<string, object>());
                var cantidadRegistrosDVV = unaConexion.EjecutarTupla<DigitoVerificadorVertical>("select Dvv from DVV", new Dictionary<string, object>());

                if (cantidadRegistrosTablaUsuario[0].Dvv == cantidadRegistrosDVV[0].Dvv)
                {

                    unaConexion.TransaccionAceptar();
                    unaConexion.ConexionFinalizar();
                    return true;
                }
                else
                {

                    unaConexion.TransaccionAceptar();
                    unaConexion.ConexionFinalizar();
                    return false;
                }
            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();

            }

            return false;
        }


    }
}
