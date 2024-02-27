using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capadedatos;
using System.Security.Cryptography;

namespace capadenegocio
{
    public class CryptographyLogic
    {
        public byte[] GenerateSalt()
        {
            // Definir la longitud del salt
            const int saltLength = 32;

            using (var randomNumberGenerator = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[saltLength];
                randomNumberGenerator.GetBytes(randomNumber);

                return randomNumber;
            }
        }

        public byte[] HashPasswordWithSalt(byte[] toBeHashed, byte[] salt)
        {
            using (var sha256 = SHA256.Create())
            {
                // Combinar la contraseña y el salt
                byte[] combinedHash = Combine(toBeHashed, salt);

                // Calcular el hash
                return sha256.ComputeHash(combinedHash);
            }
        }

        private  byte[] Combine(byte[] first, byte[] second)
        {
            var ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);

            return ret;
        }

    }
}
