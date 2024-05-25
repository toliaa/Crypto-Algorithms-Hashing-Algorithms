using System;
using System.Text;

namespace CryptoApp
{
    public static class RedocAlgorithm
    {
        private static readonly byte key = 0x55; // Спрощений ключ для демонстрації

        public static string Encrypt(string input)
        {
            byte[] data = Encoding.UTF8.GetBytes(input);
            for (int i = 0; i < data.Length; i++)
            {
                data[i] ^= key;
            }
            return Convert.ToBase64String(data);
        }

        public static string Decrypt(string input)
        {
            byte[] data = Convert.FromBase64String(input);
            for (int i = 0; i < data.Length; i++)
            {
                data[i] ^= key;
            }
            return Encoding.UTF8.GetString(data);
        }
    }
}
