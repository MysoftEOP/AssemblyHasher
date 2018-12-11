using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace AssemblyHasher.Core
{
    internal class DefaultHasher : IHasher
    {
        public string GetHash(string sourcePath)
        {
            var byteArray = File.ReadAllBytes(sourcePath);
            var md5 = new MD5CryptoServiceProvider();
            var result = md5.ComputeHash(byteArray);
            return BitConverter.ToString(result).Replace("-", "").ToLower();
        }
    }
}
