// CALABUIG BARTUAL, JORGE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadoUsuarios
{
    class Program
    {
        private static void menu()
        {
            Console.WriteLine("1.- Añadir nuevo usuario");
            Console.WriteLine("2.- Borrar usuario");
            Console.WriteLine("3.- Modificar datos de usuario existente");
            Console.WriteLine("4.- Listado de usuarios mayores de 18 años");
            Console.WriteLine("S.- Salir");
            Console.Write("Opción: ");
        }

        private static void addNuevoUsuario(ref int codigo, ListaUsuarios usuarios)
        {

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Fecha de nacimiento(DD/MM/YYYY): ");
            DateTime fecha = DateTime.Parse(Console.ReadLine());

            if (Usuario.NombreValido(nombre) && Usuario.EmailValido(email))
            {
                usuarios.AddUsuario(codigo, new Usuario(codigo, nombre, password, email, fecha));

                codigo++;
            }
        }

        private static void borrarUsuario(ListaUsuarios usuarios)
        {
            usuarios.MostrarTodos();

            Console.WriteLine("Seleccione usuario: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            usuarios.RemoveUsuario(opcion);
        }

        private static void modificarUsuario(ListaUsuarios usuarios)
        {
            usuarios.MostrarTodos();

            Console.WriteLine("Seleccione usuario: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            Usuario modificado = usuarios.GetUsuario(opcion);


            Console.Write("Nombre: " + modificado.Nombre + " Nuevo valor: ");
            string nombre = Console.ReadLine();

            if (nombre != "" && Usuario.NombreValido(nombre))
                modificado.Nombre = nombre;

            Console.Write("Email: " + modificado.Email + " Nuevo valor: ");
            string email = Console.ReadLine();

            if (email != "" && Usuario.EmailValido(email))
                modificado.Email = email;

            Console.Write("Fecha de nacimiento: " + modificado.FechaNacimiento + " Nuevo valor: ");
            string fecha = Console.ReadLine();

            if(fecha != "")
                modificado.FechaNacimiento = DateTime.Parse(fecha);

            usuarios.AddUsuario(modificado.Codigo, modificado);
        }
        static void Main(string[] args)
        {
            int siguienteCodigo = 1;
            ListaUsuarios usuarios = new ListaUsuarios();
            Serializador serializador = new Serializador("usuarios.dat");

            usuarios = serializador.Cargar();
            siguienteCodigo = usuarios.CodigoSiguienteUsuario();

            bool salir = false;
            string opcion = "";
            do
            {
                menu();
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        addNuevoUsuario(ref siguienteCodigo, usuarios);
                        break;
                    case "2":
                        borrarUsuario(usuarios);
                        break;
                    case "3":
                        modificarUsuario(usuarios);
                        break;
                    case "4":
                        usuarios.MostrarMayoresEdad();
                        break;
                    case "s":
                    case "S":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;
                }

            } while (!salir);

            serializador.Guardar(usuarios);
        }
    }
}
