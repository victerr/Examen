using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Vamos a gestionar las tareas creadas en el ejercicio anterior.
Leemos el fichero y creamos una lista con las tareas pendientes.
Sacamos por pantalla las que son para hoy o para los próximos 3 días.
Preguntamos al usuario cuales se han realizado ya y se sacan de la lista y se pasan a otra donde están las tareas realizadas.
Al acabar se vuelven a guardar las tareas pendientes en tasks.txt y las realizadas en log.txt.
*/
namespace GestionarTareas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                List<Tarea> agenda = new List<Tarea>();
                StreamReader leer = new StreamReader("tareas.txt");
                string linea;
                do
                {
                    linea = leer.ReadLine();
                    if(linea!=null)
                    {
                        string[] splitLinea = linea.Split(';');
                        string tarea="";
                        DateTime dia=DateTime.Now;
                        if (splitLinea[0] != null)
                        {
                            dia=DateTime.Parse(splitLinea[0].Trim());
                        }
                        if (splitLinea[1] != null)
                        {
                            tarea = splitLinea[1].Trim();
                        }
                        Tarea tareaNueva= new Tarea(dia, tarea);
                        agenda.Add(tareaNueva);

                    }

                } while (linea != null);
                leer.Close();

                List<Tarea> tareasRealizadas = new List<Tarea>();

                bool terminado = false;

                do
                {
                    DateTime hoy = DateTime.Now;
                    DateTime hoy1 = DateTime.Now.AddDays(1);
                    DateTime hoy2 = DateTime.Now.AddDays(2);
                    DateTime hoy3 = DateTime.Now.AddDays(3);

                    bool encontrada = false;
                    for (int i=0; i < agenda.Count; i++)
                    {                    
                        DateTime dia0 = agenda[i].GetDia();

                        /*if ((dia0.Day == hoy.Day && dia0.Month == hoy.Month && dia0.Year == hoy.Year) || 
                            (dia0.Day== hoy1.Day && dia0.Month == hoy1.Month && dia0.Year == hoy1.Year) ||
                            (dia0.Day == hoy2.Day && dia0.Month == hoy2.Month && dia0.Year == hoy2.Year) ||
                            (dia0.Day == hoy3.Day && dia0.Month == hoy3.Month && dia0.Year == hoy3.Year))
                        {
                            Console.WriteLine("{0}. {1}: {2}",i, agenda[i].GetDia(),agenda[i].GetTarea());
                            encontrada = true;
                        }*/
                        if ((dia0.ToShortDateString().CompareTo(hoy.ToShortDateString()) == 0 || dia0.ToShortDateString().CompareTo(hoy.ToShortDateString()) == 0 )&&
                            (dia0.ToShortDateString().CompareTo(hoy3.ToShortDateString()) < 0 || dia0.ToShortDateString().CompareTo(hoy3.ToShortDateString()) == 0))
                        {
                            Console.WriteLine("{0}. {1}: {2}", i, agenda[i].GetDia(), agenda[i].GetTarea());
                            encontrada = true;
                        }

                    }
                    if (encontrada)
                    {
                        Console.WriteLine("Qué número de tarea has terminado ya?, -1 para salir");
                        int numero = Convert.ToInt32(Console.ReadLine());
                        if (numero != -1)
                        {
                            tareasRealizadas.Add(agenda[numero]);
                            agenda.Remove(agenda[numero]);
                        }
                        else
                        {
                            terminado = true;
                        }
                    }
                    else
                    {
                        terminado = true;
                    }
                    

                } while (!terminado);
                
                StreamWriter escribir1 = new StreamWriter("tasks.txt");
                StreamWriter escribir2 = new StreamWriter("log.txt");

                for(int i=0; i < agenda.Count; i++)
                {
                    escribir1.WriteLine(agenda[i].GetDia() + ";" + agenda[i].GetTarea());
                }
                escribir1.Close();

                for (int i = 0; i < tareasRealizadas.Count; i++)
                {
                    escribir2.WriteLine(tareasRealizadas[i].GetDia() + ";" + tareasRealizadas[i].GetTarea());
                }
                escribir2.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error {0}", e.Message);
            }

        }
    }
}
