using System;
using System.Numerics;
using System.Text;

namespace CryptoApp
{
    public static class LucAlgorithm
    {
        // Проста реалізація криптосистеми LUC для демонстрації
        private static readonly BigInteger n = 3233; // RSA-модифікований модуль
        private static readonly BigInteger e = 17;   // Публічний ключ
        private static readonly BigInteger d = 2753; // Приватний ключ

        public static string Encrypt(string input)
        {
            byte[] data = Encoding.UTF8.GetBytes(input);
            BigInteger[] encryptedData = new BigInteger[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                encryptedData[i] = BigInteger.ModPow(data[i], e, n);
            }

            // Конвертувати BigInteger в строку для зручного відображення
            StringBuilder sb = new StringBuilder();
            foreach (var item in encryptedData)
            {
                sb.Append(item.ToString() + " ");
            }
            return sb.ToString();
        }

        public static string Decrypt(string input)
        {
            string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            byte[] decryptedData = new byte[tokens.Length];
            for (int i = 0; i < tokens.Length; i++)
            {
                BigInteger encryptedByte = BigInteger.Parse(tokens[i]);
                decryptedData[i] = (byte)BigInteger.ModPow(encryptedByte, d, n);
            }
            return Encoding.UTF8.GetString(decryptedData);
        }
    }
}
