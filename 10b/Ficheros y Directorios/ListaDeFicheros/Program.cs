//Víctor Ivorra Alberola
using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeFicheros
{
    class Program
    {
        static void Main(string[] args)
        {
            string miDirectorio = @"C:\Users\Victor\Desktop\DAW\Programacion\2ª Eval\POO\Ejercicios\POO\";
            DirectoryInfo dir = new DirectoryInfo(miDirectorio);
            FileInfo[] infoFicheros = dir.GetFiles();
            int mayor = 0;

            for (int i = 0; i < infoFicheros.Length; i++)
            {
                if (infoFicheros[i].Length > infoFicheros[mayor].Length)
                {
                    mayor = i;
                }
            }

            for (int i = 0; i < infoFicheros.Length; i++)
            {
                if (i == mayor)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0}, de tamaño {1}, creado {2}", infoFicheros[i].Name, infoFicheros[i].Length, infoFicheros[i].CreationTime);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("{0}, de tamaño {1}, creado {2}", infoFicheros[i].Name, infoFicheros[i].Length, infoFicheros[i].CreationTime);
                }

            }
            
        }
    }
}
