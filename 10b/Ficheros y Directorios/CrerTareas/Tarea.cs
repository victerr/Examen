using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrerTareas
{
    class Tarea
    {
        string desc;
        string repeticion;

        public Tarea(string desc, string repeticion)
        {
            this.desc = desc;
            this.repeticion = repeticion;
        }

        public string getDesc()
        {
            return this.desc;
        }

        public void setDesc(string desc)
        {
            this.desc = desc;
        }

        public string getRepeticion()
        {
            return this.repeticion;
        }

        public void setRepeticion(string repeticion)
        {
            this.repeticion = repeticion;
        }

    }
}
