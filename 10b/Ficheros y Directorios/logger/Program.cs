//Víctor Ivorra Alberola
using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto="";
            StreamWriter ficheroEscritura;

            for (int i = 0; i < args.Length; i++)
            {
                texto += args[i] + " ";
            }

            try
            {
                ficheroEscritura = new StreamWriter("log.txt", true);
                
                ficheroEscritura.WriteLine(DateTime.Today.ToShortDateString() + " - " + texto);

                ficheroEscritura.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.Write(e.Message);
            }
            catch (IOException e)
            {
                Console.Write(e.Message);
            }

        }
    }
}
