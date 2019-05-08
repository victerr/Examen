using System;
using System.IO;

namespace ComandanteNorton
{
    class Explorador
    {
        int lineaInicial;
        int lineaFinal;
        int lineaActual;
        string[] listaFicheros;

        public Explorador()
        {
            lineaInicial = 0;
            lineaFinal = 23;
        }

        public int GetLenght()
        {
            return listaFicheros.Length;
        }

        public void LeeFicheros()
        {
            listaFicheros = Directory.GetFiles(@"C:\Users\Victor\Desktop\DAW\Programacion\2ª Eval\POO\Ejercicios\POO\");
        }

        public void CursorArriba()
        {
            if (lineaInicial - 1 >= 0)
            {
                lineaInicial--;
                lineaFinal--;
                lineaActual--;
            }
            else
            {
                if (lineaActual - 1 >= 0)
                {
                    lineaActual--;
                }
            }

            
            Mostrar(lineaInicial, lineaFinal, lineaActual);
        }

        public void CursorAbajo()
        {
            if (lineaFinal + 1 < listaFicheros.Length - 1)
            {
                lineaInicial++;
                lineaFinal++;
                lineaActual++;
            }
            else
            {
                if (lineaActual + 1 < listaFicheros.Length - 1)
                {
                    lineaActual++;
                }
            }
            Mostrar(lineaInicial, lineaFinal, lineaActual);
        }

        public void Mostrar(int lineaInicial, int lineaFinal, int lineaActual)
        {
            Console.Clear();

            string linea;

            for (int i = lineaInicial; i <= lineaFinal; i++)
            {
                linea = listaFicheros[i];

                if (i == lineaActual)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine(linea);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(linea);
                }
            }

            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.Write("Líneas: " + (lineaInicial + 1) + "-" + (lineaFinal + 1) + "/" + (listaFicheros.Length - 1));
        }

    }
}
