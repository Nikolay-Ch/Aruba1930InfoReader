using System;

namespace Aruba1930Cli
{
    class Program
    {
        static void Main()
        {
            var aruba = new Aruba1930WebParser(Environment.GetEnvironmentVariable("BaseUri")!);

            aruba.Login(
                Environment.GetEnvironmentVariable("UserName")!,
                Environment.GetEnvironmentVariable("UserPass")!)
                .Wait();

            var res2 = aruba.GetAllStatuses().Result;

            Console.WriteLine("Hello World!");
        }
    }
}
