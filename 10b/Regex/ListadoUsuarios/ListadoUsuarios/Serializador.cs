using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ListadoUsuarios
{
    class Serializador
    {
        string fichero;

        public Serializador(string fichero)
        {
            this.fichero = fichero;
        }

        public ListaUsuarios Cargar()
        {
            ListaUsuarios data = new ListaUsuarios();

            try
            {
                if (File.Exists(fichero))
                {

                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream(fichero, FileMode.Open, FileAccess.Read, FileShare.Read);

                    data = (ListaUsuarios) formatter.Deserialize(stream);

                    stream.Close();
                }

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No se encuentra el fichero");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("La ruta es demasiado larga");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("El nombre del fichero no puede ser nulo");
            }

            return data;
        }


        public void Guardar(ListaUsuarios data)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(fichero, FileMode.Create, FileAccess.Write, FileShare.None);

                formatter.Serialize(stream, data);

                stream.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No se encuentra el fichero");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("La ruta es demasiado larga");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("El nombre del fichero no puede ser nulo");
            }

        }
    }
}
