//Víctor Ivorra Alberola
using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitemap
{
    class Program
    {
        static void Main(string[] args)
        {
            string rutaWeb = args[0];
            string rutaDisco = args[1];
            DirectoryInfo dir = new DirectoryInfo(rutaDisco);
            FileSystemInfo[] files = dir.GetFiles();
            FileSystemInfo[] subFiles;
            FileSystemInfo[] directories = dir.GetDirectories();
            StreamWriter fichero = File.CreateText("sitemap.html");
            
            fichero.WriteLine("<?xml version=\"1.0\" encoding=\"utf - 8\"?> \n<urlset xmlns = \"http://www.sitemaps.org/schemas/sitemap/0.9\"> ");


            for (int i = 0; i < files.Length; i++)
            {
                GeneraURL(files[i], rutaWeb, fichero);
            }
            for (int i = 0; i < directories.Length; i++)
            {
                dir = new DirectoryInfo(rutaDisco +"\\"+ directories[i]);
                subFiles = dir.GetFiles();
                for (int j = 0; j < subFiles.Length; j++)
                {
                    GeneraURL2(subFiles[j], directories[i], rutaWeb, fichero);
                }
            }

            fichero.Write("</urlset>");
            fichero.Close();
        }

        public static void GeneraURL(FileSystemInfo cadena, string ruta, StreamWriter fichero)
        {
            fichero.WriteLine("<url>\n<loc>" + ruta + "\\" + cadena.Name + "</loc>");
            fichero.WriteLine("<lastmod>" + DateTime.Now.ToShortDateString() + "</lastmod>");
            fichero.WriteLine("<changefreq>weekly</changefreq>\n</url>");
        }
        public static void GeneraURL2(FileSystemInfo cadena, FileSystemInfo cadena2, string ruta, StreamWriter fichero)
        {
            fichero.WriteLine("<url>\n<loc>" + ruta + "\\" + cadena2.Name + "\\" + cadena.Name + "</loc>");
            fichero.WriteLine("<lastmod>" + DateTime.Now.ToShortDateString() + "</lastmod>");
            fichero.WriteLine("<changefreq>weekly</changefreq>\n</url>");
        }
    }
}
