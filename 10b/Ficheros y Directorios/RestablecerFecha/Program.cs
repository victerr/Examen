//Víctor Ivorra Alberola
using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestablecerFecha
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string patron;
            string orden="";

            if (args.Length == 2)
            {
                patron = args[0];
                orden = args[1];

                DirectoryInfo dir = new DirectoryInfo(".");
                FileSystemInfo[] listaFicheros = dir.GetFiles(patron);

                switch (orden)
                {
                    case "guardar":
                    StreamWriter ficheroEscritura = File.CreateText("fechas.txt");

                    foreach (var item in listaFicheros)
                    {
                        ficheroEscritura.WriteLine(item.Name + ";" + item.CreationTime);
                    }
                    ficheroEscritura.Close();

                    break;

                    case "restaurar":
                    StreamReader ficheroLectura = File.OpenText("fechas.txt");
                    string linea="";
                    string[] lineaSplit;
                    int contador = 0;
                    DateTime fecha;

                    while (linea != null)
                    {
                        linea = ficheroLectura.ReadLine();

                        if (!string.IsNullOrEmpty(linea))
                        {
                            lineaSplit = linea.Split(';');
                            fecha = Convert.ToDateTime(lineaSplit[1]);

                            listaFicheros[contador].CreationTime = fecha;
                            contador++;
                        }
                    }
                    
                    break;
                }
            }
            else
            {
                Console.WriteLine("Error. Número de argumentos incorrecto.");
            }

            
        }
    }
}
