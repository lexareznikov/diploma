using System;
using System.Security.Cryptography;
using System.Text;

namespace Demography.BusinessLayer.Utility
{
    public static class Crypto
    {
        static public string GetMd5Hash(string input)
        {
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input)); // Конвертирует строку в байты уже захешированные

            var sBuilder = new StringBuilder();

            foreach (byte t in data)
                sBuilder.Append(t.ToString("x2")); //каждый байт в виде 16-й строки.

            return sBuilder.ToString(); //возвращает 16 ричную строку.
        }

        static public bool VerifyMd5Hash(string input, string hash)
        {
            string hashOfInput = GetMd5Hash(input);

            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return 0 == comparer.Compare(hashOfInput, hash);
        }

        static public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyz1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
    }
}
