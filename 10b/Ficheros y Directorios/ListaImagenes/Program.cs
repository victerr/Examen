//Víctor Ivorra Alberola
using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaImagenes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listaPNG = Directory.GetFiles(".", "*.png");
            string[] listaJPG = Directory.GetFiles(".", "*.jpg");
            StreamWriter ficheroEscritura;

            try
            {
                ficheroEscritura = File.CreateText("imagenes.html");

                ficheroEscritura.WriteLine("<html>");
                ficheroEscritura.WriteLine("<body>");
                ficheroEscritura.WriteLine("<ul>");

                for (int i = 0; i < listaPNG.Length; i++)
                {
                    ficheroEscritura.WriteLine("<li><a href='" + listaPNG[i] + "'> " + listaPNG[i] + "</a></li>");
                }
                for (int i = 0; i < listaJPG.Length; i++)
                {
                    ficheroEscritura.WriteLine("<li><a href='" + listaJPG[i] + "'> " + listaJPG[i] + "</a></li>");
                }

                ficheroEscritura.WriteLine("</ul>");
                ficheroEscritura.WriteLine("</html>");
                ficheroEscritura.WriteLine("</body>");

                ficheroEscritura.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("El fichero no existe {0}", e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
