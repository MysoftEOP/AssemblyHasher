using AssemblyHasher.Core;
using System;

namespace AssemblyHasher.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            var path = @"D:\workspace\rdc\AssemblyComparer\AssemblyComparer.Core\bin\Debug\netstandard2.0\AssemblyComparer.Core.dll";

            var factory = HasherFactory.CreateHasher(path);

            var md5 = factory.GetHash(path);

            System.Console.ReadKey();
        }
    }
}
