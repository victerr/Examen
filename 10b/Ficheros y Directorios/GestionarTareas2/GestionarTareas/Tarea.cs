using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionarTareas
{
    class Tarea
    {
        DateTime dia;
        string tarea;

        public Tarea(DateTime dia, string tarea)
        {
            this.dia = dia;
            this.tarea = tarea;
        }
        public DateTime GetDia()
        {
            return dia;
        }
        public string GetTarea()
        {
            return tarea;
        }
        
    }
}
