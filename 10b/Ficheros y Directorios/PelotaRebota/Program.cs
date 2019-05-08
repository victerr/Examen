//Víctor Ivorra Alberola
using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PelotaRebota
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Pelota pelota = new Pelota(1,1,1,1);
            while (true)
            {
                Console.CursorVisible=false;
                pelota.Mover();
                if (pelota.HayColision())
                {
                    Console.ForegroundColor = (ConsoleColor)rnd.Next(0, 16);
                    pelota.CambiarDireccion();
                }
            }
        }
    }
}
