﻿using System.Security.Cryptography;
using System.Text;

namespace cz.kr_vysocina.nis.v11.mock
{
    public static class SHA1Util
    {
        /// <summary>
        /// Compute hash for string encoded as UTF8
        /// </summary>
        /// <returns>40-character hex string</returns>
        public static string SHA1HashStringForUTF8String(byte[] bytes)
        {
            var sha1 = SHA1.Create();
            byte[] hashBytes = sha1.ComputeHash(bytes);

            return HexStringFromBytes(hashBytes);
        }

        /// <summary>
        /// Convert an array of bytes to a string of hex digits
        /// </summary>
        /// <param name="bytes">array of bytes</param>
        /// <returns>String of hex digits</returns>
        public static string HexStringFromBytes(byte[] bytes)
        {
            var sb = new StringBuilder();
            foreach (byte b in bytes)
            {
                var hex = b.ToString("x2");
                sb.Append(hex);
            }

            return sb.ToString();
        }
    }
}