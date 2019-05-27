using AssemblyHasher.Core;
using System;

namespace AssemblyHasher.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Hello World!");

            //var path = @"E:\FileClientAPI\2\myDoc.ApiClient.dll";

            //var factory = HasherFactory.CreateHasher(path);

            //var md5 = factory.GetHash(path);

            //System.Console.WriteLine(md5);

            var path = @"E:\test\AssemblyHasher.Core.dll";

            //factory = HasherFactory.CreateHasher(path);

            //md5 = factory.GetHash(path);

            //System.Console.WriteLine(md5);

            var md5 = HasherFactory.GetHash(path);

            System.Console.WriteLine(md5);

            var md5default = HasherFactory.GetHash(path,HasherEnum.Default);

            System.Console.WriteLine(md5default);

            var md5lhasher = HasherFactory.GetHash(path, HasherEnum.IlHasher);

            System.Console.WriteLine(md5lhasher);

            System.Console.ReadKey();
        }
    }
}
