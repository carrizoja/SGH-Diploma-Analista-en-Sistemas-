using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Carrizo.Encriptadores
{
    /// <summary>
    /// Clase encargada de los diferentes tipos de encriptaciones
    /// </summary>
    public class Encriptador
    {

        /// <summary>
        /// Encriptars the specified palabra a encriptar.
        /// </summary>
        /// <param name="palabraAEncriptar">The palabra a encriptar.</param>
        /// <returns></returns>
        public static string Encriptar(string palabraAEncriptar)
        {
            string resultado = string.Empty;
            Byte[] encriptar = System.Text.Encoding.Unicode.GetBytes(palabraAEncriptar);
            resultado = Convert.ToBase64String(encriptar);

            return resultado;
        }

        /// <summary>
        /// Desencriptars the specified palabra a encriptar.
        /// </summary>
        /// <param name="palabraAEncriptar">The palabra a encriptar.</param>
        /// <returns></returns>
        public static string Desencriptar(string palabraAEncriptar)
        {
            string resultado = string.Empty;
            Byte[] desencriptar = Convert.FromBase64String(palabraAEncriptar); //alf

            resultado = System.Text.Encoding.Unicode.GetString(desencriptar);

            return resultado;
        }

        /// <summary>
        /// Realizars the MD5 hash.
        /// </summary>
        /// <param name="md5Hash">The MD5 hash.</param>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static string RealizarMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }


        /// <summary>
        /// Verificars the MD5 hash.
        /// </summary>
        /// <param name="md5Hash">The MD5 hash.</param>
        /// <param name="input">The input.</param>
        /// <param name="hash">The hash.</param>
        /// <returns></returns>
        public static bool VerificarMd5Hash(MD5 md5Hash, string input, string hash)
        {
            string hashOfInput = RealizarMd5Hash(md5Hash, input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(hashOfInput, hash))       // Averiguar por qué no funciona con "=="
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
