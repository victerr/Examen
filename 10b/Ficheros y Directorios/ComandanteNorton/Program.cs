//Víctor Ivorra Alberola
using System;

namespace ComandanteNorton
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo input;
            bool salir = false;
            Console.CursorVisible = false;

            Explorador explorer = new Explorador();
            explorer.LeeFicheros();

            explorer.Mostrar(0, explorer.GetLenght()-1, 0);

            do
            {
                input = Console.ReadKey(false);

                switch (input.Key)
                {
                    case ConsoleKey.UpArrow:
                    explorer.CursorArriba();
                    break;

                    case ConsoleKey.DownArrow:
                    explorer.CursorAbajo();
                    break;

                    case ConsoleKey.Escape:
                    salir = true;
                    break;

                }

            } while (!salir);


            Console.Clear();
            Console.WriteLine("Fin del programa.");
        }
    }
}
