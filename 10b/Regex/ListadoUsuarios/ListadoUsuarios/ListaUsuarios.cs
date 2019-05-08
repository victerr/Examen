using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadoUsuarios
{
    [Serializable]
    class ListaUsuarios
    {
        Dictionary <int, Usuario> lista;

        public ListaUsuarios()
        {
            this.lista = new Dictionary<int, Usuario>();
        }


        public void AddUsuario(int codigo, Usuario usuario)
        {
            lista.Add(codigo, usuario);
        }

        public void RemoveUsuario(int codigo)
        {
            if(lista.ContainsKey(codigo))
                lista.Remove(codigo);
        }

        public Usuario GetUsuario(int codigo)
        {
            Usuario usuario = new Usuario();

            if (lista.ContainsKey(codigo))
            {
                usuario = lista[codigo];
                lista.Remove(codigo);
            }

            return usuario;
        }
        public void MostrarTodos()
        {
            IDictionaryEnumerator ide = lista.GetEnumerator();

            while (ide.MoveNext())
                Console.WriteLine(((Usuario) ide.Value).ToString());

        }

        public void MostrarMayoresEdad()
        {
            IDictionaryEnumerator ide = lista.GetEnumerator();

            while (ide.MoveNext())
                if(((Usuario) ide.Value).EsMayorEdad())
                    Console.WriteLine(((Usuario)ide.Value).ToString());

        }

        public int CodigoSiguienteUsuario()
        {
            int siguiente = 0;

            IDictionaryEnumerator ide = lista.GetEnumerator();

            while (ide.MoveNext())
            {
               siguiente = (siguiente < (int)ide.Key) ? (int)ide.Key : siguiente;
            }

            return ++siguiente;
        }

    }
}
