//Víctor Ivorra Alberola
using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UsuarioContrasenya
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string contrasenya;

            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Contraseña: ");
            contrasenya = Console.ReadLine();
            
            if (UsuarioCorrecto(nombre))
            {
                Console.WriteLine("El usuario es correcto.");
            }
            else
            {
                Console.WriteLine("El usuario NO es correcto.");
            }

            if (ContrasenyaCorrecta(contrasenya))
            {
                Console.WriteLine("La contraseña es correcta.");
            }
            else
            {
                Console.WriteLine("La contraseña NO es correcta.");
            }

        }

        public static bool UsuarioCorrecto(string cadena)
        {
            Regex nombreCorrecto = new Regex(@"\A[U]{1}[a-zA-Z0-9]*\z");
            return nombreCorrecto.IsMatch(cadena);
        }

        public static bool ContrasenyaCorrecta(string cadena)
        {
            Regex contrasenyaCorrecta = new Regex("[A-Z]+[0-9]+");
            return contrasenyaCorrecta.IsMatch(cadena);
        }
    }
}