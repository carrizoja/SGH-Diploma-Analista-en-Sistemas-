using System.Collections.Generic;

namespace Framework.Carrizo.Persistencia
{
    /// <summary>
    /// Interface iConnection utilizada para acceder a la BD
    /// </summary>
    public interface IConnection
    {
        /// <summary>
        /// Finaliza la conexión
        /// </summary>
        void ConexionFinalizar();
        /// <summary>
        /// Inicia transacción
        /// </summary>
        void TransaccionIniciar();
        /// <summary>
        /// Acepta la transacción
        /// </summary>
        void TransaccionAceptar();
        /// <summary>
        /// Cancela la transacción
        /// </summary>
        void TransaccionCancelar();

        /// <summary>
        /// Nueva  conexion.
        /// </summary>
        /// <param name="conexion">The conexion.</param>
        void NuevaConexion(string conexion);

        /// <summary>
        /// Ejecuta  sin resultado.
        /// </summary>
        /// <param name="consulta">The consulta.</param>
        /// <param name="parametros">The parametros.</param>
        void EjecutarSinResultado(string consulta, Dictionary<string, object> parametros);

        /// <summary>
        /// Ejecutar el escalar.
        /// </summary>
        /// <param name="consulta">The consulta.</param>
        /// <param name="parametros">The parametros.</param>
        /// <returns></returns>
        object EjecutarEscalar(string consulta, Dictionary<string, object> parametros);

        /// <summary>
        /// Ejecuta tupla.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="consulta">The consulta.</param>
        /// <param name="parametros">The parametros.</param>
        /// <returns></returns>
        List<T> EjecutarTupla<T>(string consulta, Dictionary<string, object> parametros) where T : new();

    }
}