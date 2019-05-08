using System.Collections.Generic;

namespace CrerTareas
{
    class ListaDeTareas
    {
        List<Tarea> listaTareas;

        public ListaDeTareas()
        {
            listaTareas = new List<Tarea>();
        }

        public void AddTarea(Tarea tarea)
        {
            listaTareas.Add(tarea);
        }

        public int GetLength()
        {
            return listaTareas.Count;
        }

        public List<Tarea> GetLista()
        {
            return listaTareas;
        }
    }
}
