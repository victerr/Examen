//Víctor Ivorra Alberola
using System;
using System.Text.RegularExpressions;

namespace ValidarNombreUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();


            if (EsIdentificadorValido(nombre))
            {
                Console.WriteLine("El nombre es correcto.");
            }
            else
            {
                Console.WriteLine("El nombre NO es correcto.");
            }
        }

        public static bool EsIdentificadorValido(string cadena)
        {
            Regex nombreCorrecto = new Regex(@"\A[a-z]{1}[a-zA-Z0-9]*\z");
            return nombreCorrecto.IsMatch(cadena);
        }
    }
}
