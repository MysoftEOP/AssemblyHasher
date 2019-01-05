using AssemblyHasher.Core;
using System;

namespace AssemblyHasher.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Hello World!");

            var path = @"E:\FileClientAPI\2\myDoc.ApiClient.dll";

            var factory = HasherFactory.CreateHasher(path);

            var md5 = factory.GetHash(path);

            System.Console.WriteLine(md5);

            path = @"E:\myDoc.ApiClient.dll";

            factory = HasherFactory.CreateHasher(path);

            md5 = factory.GetHash(path);

            System.Console.WriteLine(md5);

            System.Console.ReadKey();
        }
    }
}
