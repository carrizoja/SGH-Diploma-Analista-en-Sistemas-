using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;


namespace Framework.Carrizo.Persistencia
{
    /// <summary>
    /// Interfaz utilizada para la conexión a Sql Server
    /// </summary>
    /// <seealso cref="Framework.Carrizo.Persistencia.IConnection" />
    public class SqlServerConnection : IConnection
    {
        private SqlConnection _sqlConnection;
        private SqlTransaction _oneTransaction;


        /// <summary>
        /// Finaliza la conexión
        /// </summary>
        public void ConexionFinalizar()
        {
            if (_sqlConnection.State != System.Data.ConnectionState.Closed)
            {
                _sqlConnection.Close();
            }
        }

        /// <summary>
        /// Ejecutar el escalar.
        /// </summary>
        /// <param name="consulta">The consulta.</param>
        /// <param name="parametros">The parametros.</param>
        /// <returns></returns>
        public object EjecutarEscalar(string consulta, Dictionary<string, object> parametros)
        {
            SqlCommand oneCommand = new SqlCommand();
            oneCommand.Connection = _sqlConnection;
            oneCommand.Transaction = _oneTransaction;

            oneCommand.CommandText = consulta;

            foreach (var p in parametros)
            {
                oneCommand.Parameters.AddWithValue(p.Key, p.Value);
            }

            oneCommand.CommandType = CommandType.Text;

            return oneCommand.ExecuteScalar();


        }
        /// <summary>
        /// Ejecuta  sin resultado.
        /// </summary>
        /// <param name="consulta">The consulta.</param>
        /// <param name="parametros">The parametros.</param>
        public void EjecutarSinResultado(string consulta, Dictionary<string, object> parametros)
        {

            SqlCommand oneCommand = new SqlCommand();

            oneCommand.Connection = _sqlConnection;
            oneCommand.Transaction = _oneTransaction;

            oneCommand.CommandText = consulta;

            foreach (var p in parametros)
            {
                SqlParameter param = new SqlParameter();
                oneCommand.Parameters.AddWithValue(p.Key, p.Value);
            }


            oneCommand.CommandType = CommandType.Text;

            oneCommand.ExecuteNonQuery();

        }
        /// <summary>
        /// Ejecuta sin resultado DVV.
        /// </summary>
        /// <param name="consulta">The consulta.</param>
        public void EjecutarSinResultadoDVV(string consulta)
        {

            SqlCommand oneCommand = new SqlCommand();

            oneCommand.Connection = _sqlConnection;
            oneCommand.Transaction = _oneTransaction;

            oneCommand.CommandText = consulta;

           

            oneCommand.CommandType = CommandType.Text;

            oneCommand.ExecuteNonQuery();

        }
        /// <summary>
        /// Ejecuta tupla.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="consulta">The consulta.</param>
        /// <param name="parametros">The parametros.</param>
        /// <returns></returns>
        public List<T> EjecutarTupla<T>(string consulta, Dictionary<string, object> parametros) where T : new()
        {
            List<T> finalResult = new List<T>();
            SqlCommand oneCommand = new SqlCommand();


            oneCommand.Connection = _sqlConnection;
            oneCommand.Transaction = _oneTransaction;

            oneCommand.CommandText = consulta;

            foreach (var p in parametros)
            {
                SqlParameter param = new SqlParameter();
                oneCommand.Parameters.AddWithValue(p.Key, p.Value);
            }

            oneCommand.CommandType = CommandType.Text;

            SqlDataReader resultDataReader = oneCommand.ExecuteReader();

            while (resultDataReader.Read())
            {
                T resultObject = new T();

                for (int i = 0; i <= resultDataReader.FieldCount - 1; i++) //alf test here
                {
                    string columnName = resultDataReader.GetName(i);
                    object columnValue = resultDataReader[i];

                    PropertyInfo pi = resultObject.GetType().GetProperty(columnName);
                    if (pi != null)
                    {
                        pi.SetValue(resultObject, columnValue);
                    }


                }

                finalResult.Add(resultObject);

            }

            resultDataReader.Close();
            return finalResult;


        }
        /// <summary>
        /// Nueva conexion.
        /// </summary>
        /// <param name="connection">The connection.</param>
        public void NuevaConexion(string connection)
        {
            _sqlConnection = new SqlConnection(connection);
            _sqlConnection.Open();

        }
        /// <summary>
        /// Acepta la transacción
        /// </summary>
        public void TransaccionAceptar()
        {
            _oneTransaction.Commit(); 
        }
        /// <summary>
        /// Cancela la transacción
        /// </summary>
        public void TransaccionCancelar()
        {
            _oneTransaction.Rollback();
        }
        /// <summary>
        /// Inicia transacción
        /// </summary>
        public void TransaccionIniciar()
        {
            _oneTransaction = _sqlConnection.BeginTransaction();
        }
    }
}
