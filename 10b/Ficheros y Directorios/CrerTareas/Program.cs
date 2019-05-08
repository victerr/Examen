//Víctor Ivorra Alberola
using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrerTareas
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeTareas lista = new ListaDeTareas();
            Tarea tarea;
            string desc, repeticion;

            do
            {
                Console.Write("Descripción: ");
                desc = Console.ReadLine();

                if(desc != "fin")
                {
                    Console.Write("Repetición: ");
                    repeticion = Console.ReadLine();

                    tarea = new Tarea(desc, repeticion);

                    lista.AddTarea(tarea);
                }


            } while (desc != "fin");

            EscribeTareas(lista);
            


        }
        
        public static void EscribeTareas(ListaDeTareas lista)
        {
            DateTime fecha = DateTime.Now;
            StreamWriter fichero;

            try
            {
                fichero = File.CreateText("tareas.txt");

                for (int i = 0; i < lista.GetLength(); i++)
                {
                    if (lista.GetLista()[i].getRepeticion().ToLower() == "mensual")
                    {
                        for (int j = 0; j < 12; j++)
                        {
                            fichero.Write(lista.GetLista()[i].getDesc() + " ");
                            fichero.WriteLine(fecha.AddMonths(j));
                        }
                    }
                    else
                    {
                        DateTime fechaActual = DateTime.Now;
                        DateTime finAnyo = new DateTime(2019, 12, 31);
                        TimeSpan diferencia = finAnyo.Subtract(fechaActual);

                        
                        for (int k = 0; k <= ((int)diferencia.TotalDays)/7 ; k++)
                        {
                            fichero.Write(lista.GetLista()[i].getDesc() + " ");
                            fichero.WriteLine(fecha.AddDays(k * 7));
                        }

                    }
                    
                }
                fichero.Close();

            }
            catch(IOException e)
            {
                Console.Write(e.Message);

            }
            catch (Exception e)
            {
                Console.Write(e.Message);

            }
            
        }
    }
}
