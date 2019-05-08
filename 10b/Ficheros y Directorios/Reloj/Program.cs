//Víctor Ivorra Alberola
using System;
using System.Threading;

namespace Reloj
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write(DateTime.Now.ToLongTimeString());
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
