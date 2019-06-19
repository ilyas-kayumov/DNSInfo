using System;
using System.Net;

namespace DNSInfo
{
    public class Printer
    {
        public void PrintInvalidArguments()
        {
            Console.WriteLine("Invalid number of arguments");
        }

        public void PrintBeginLoading()
        {
            Console.Write("Loading");
        }

        public void PrintLoadingProgress()
        {
            Console.Write(".");
        }

        public void PrintEndBeginLoading()
        {
            Console.WriteLine();
        }

        public void PrintBeginAdresses()
        {
            Console.WriteLine("Adresses:\n");
        }

        public void PrintAdress(IPAddress adress)
        {
            Console.WriteLine(adress.ToString());
            Console.WriteLine(adress.AddressFamily);
            Console.WriteLine();
        }

        public void PrintError(Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}
