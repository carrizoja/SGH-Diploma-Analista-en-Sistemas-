using SGH.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Carrizo.Persistencia;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace SGH.Servicios
{


    /// <summary>Mapper de Backup - Restore</summary>
    public class DALBackupRestore
    {
        /// <summary>
        /// Graba datos backup.
        /// </summary>
        /// <param name="nombreBaseDeDatos">The nombre base de datos.</param>
        /// <param name="rutaBase">The ruta base.</param>
        /// <param name="nombreBackup">The nombre backup.</param>
        /// <param name="nombreUsuario">The nombre usuario.</param>
        public void GrabarDatosBackup(string nombreBaseDeDatos, string rutaBase, string nombreBackup, string nombreUsuario)
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@NombreBase", nombreBaseDeDatos);
                parametros.Add("@NombreBackup", nombreBackup);
                parametros.Add("@Ruta", rutaBase);
                parametros.Add("@Usuario", nombreUsuario);

                unaConexion.EjecutarSinResultado("insert into BackupHistorico values(NEWID(),@NombreBase,@NombreBackup,@Ruta,@Usuario,SYSDATETIME())", parametros);
            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();

            }

            unaConexion.TransaccionAceptar();
            unaConexion.ConexionFinalizar();
        }
        /// <summary>
        /// Hace restore.
        /// </summary>
        /// <param name="nombreBase">The nombre base.</param>
        /// <param name="ruta">The ruta.</param>
        public void HacerRestore(string nombreBase, string ruta)
        {
            
            string connectionString = SGH.Servicios.Configuracion.ObtenerStringConexionSqlServerParaBackupRestore();
            // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            try
            {
                string sql = "ALTER DATABASE " + nombreBase + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql += "RESTORE DATABASE " + nombreBase + " FROM DISK = '" + ruta + "'WITH REPLACE;";
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                MessageBox.Show("Restore Completado!");
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Dispose();
                conn.Close();
                MessageBox.Show("Error en el Restore. " + ex.Message);
            }
        }
        /// <summary>
        /// Hace backup.
        /// </summary>
        /// <param name="nombreBase">The nombre base.</param>
        /// <param name="ruta">The ruta.</param>
        /// <param name="nombreBackup">The nombre backup.</param>
        public void HacerBackup(string nombreBase, string ruta, string nombreBackup)
        {

            string connectionString = SGH.Servicios.Configuracion.ObtenerStringConexionSqlServerParaBackupRestore();
            SqlConnection conn = new SqlConnection(connectionString);
            // string conexion = ConfigurationManager.AppSettings["SGHConnection"];

            conn.Open();
            try
            {

                SqlCommand command = new SqlCommand();

                string sql = "BACKUP DATABASE " + nombreBase + " TO DISK = '" + ruta + "\\" + nombreBackup + "-" + DateTime.Now.Ticks.ToString() + ".bak'";

                command.CommandText = sql;
                command.Connection = conn;

                command.ExecuteNonQuery();
                MessageBox.Show("Backup Completado!");
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error. " + ex.Message);
                conn.Close();
            }
        }
        /// <summary>
        /// Trae bases de datos.
        /// </summary>
        /// <returns></returns>
        public List<String> TraerBasesDeDatos()
        {
            string connectionString = SGH.Servicios.Configuracion.ObtenerStringConexionSqlServerParaBackupRestore();
            SqlConnection conn = new SqlConnection(connectionString);
            // string conexion = ConfigurationManager.AppSettings["SGHConnection"];

            conn.Open();
            List<String> nameDatabases = new List<String>();
            try
            {
                string sql = "Exec sp_databases";
                SqlCommand command = new SqlCommand(sql, conn);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    nameDatabases.Add(reader[0].ToString());
                }
                conn.Dispose();
                conn.Close();
                conn.Dispose();
            }
            catch (Exception ex)
            {
                conn.Dispose();
                conn.Close();
            }
            return nameDatabases;
        }
        /// <summary>
        /// Trae datos backup.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Backup> TraerDatosBackup()
        {
            SqlServerConnection unaConexion = new SqlServerConnection();
            string conexion = Servicios.Configuracion.ObtenerStringConexionSqlServer();
            // string conexion = ConfigurationManager.AppSettings["SGHConnection"];
            unaConexion.NuevaConexion(conexion);

            try
            {
                unaConexion.TransaccionIniciar();

                var datosBackup = unaConexion.EjecutarTupla<Backup>("Select * from BackupHistorico", new Dictionary<string, object>());

                unaConexion.ConexionFinalizar();

                return datosBackup;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
    }


}

