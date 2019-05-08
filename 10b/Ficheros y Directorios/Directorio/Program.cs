//Víctor Ivorra Alberola
using System;
using System.IO;

namespace Directorio
{
    class Program
    {
        static void Main(string[] args)
        {
            string comando;
            string dir1 = "";
            string dir2 = "";
            string path = Directory.GetCurrentDirectory();

            if (args.Length == 3 || (args[0] != "mover" && args.Length == 2))
            {
                comando = args[0];
                dir1 = args[1];
                if (args.Length == 3)
                {
                    dir2 = args[2];
                }

                DirectoryInfo dir = new DirectoryInfo(path);
                FileSystemInfo[] listaFicheros = dir.GetDirectories();


                switch (comando)
                {
                    case "crear":

                    if (Directory.Exists(dir1))
                    {
                        Console.WriteLine("El fichero que intentas crear ya existe.");
                    }
                    else
                    {
                        Directory.CreateDirectory(dir1);
                    }

                    break;

                    case "mover":


                    if (Directory.Exists(dir1))
                    {
                        if (!Directory.Exists(dir2))
                        {
                            Directory.Move(dir1, dir2);
                        }
                        else
                        {
                            Console.Write("El directorio destino ya existe. No se cambiará el nombre");
                        }
                    }
                    else
                    {
                        Console.WriteLine("El directorio origen no existe. No se cambiará el nombre");
                    }

                    break;

                    case "borrar":

                    if (Directory.Exists(dir1))
                    {
                        Directory.Delete(dir1);
                    }
                    else
                    {
                        Console.WriteLine("El directorio que intentas borrar no existe.");
                    }
                    break;

                    case "explorar":

                    if (Directory.Exists(dir1))
                    {
                        string[] listaDirectorios = Directory.GetDirectories(dir1);
                        string[] listaArchivos = Directory.GetFiles(dir1);

                        Muestra(listaDirectorios);
                        Muestra(listaArchivos);
                    }
                    else
                    {
                        Console.WriteLine("El directorio que intentas explorar no existe.");
                    }

                    break;
                }
            }
            else
            {
                Console.WriteLine("Error. Número de argumentos incorrecto.");
            }
        }

        public static void Muestra(string[] lista)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }
    }
}
