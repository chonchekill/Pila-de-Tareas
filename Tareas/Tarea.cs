using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas
{
    internal class Tarea
    {
        public int idTarea {  get; set; }
        public string descripcionTarea { get; set; }

        public bool estadoTarea { get; set; }

        public Tarea siguienteTarea;

        public Tarea(int idTarea, string descripcionTarea, bool estadoTarea, Tarea siguienteTarea)
        {

            this.idTarea = idTarea;
            this.descripcionTarea = descripcionTarea;
            this.estadoTarea = false;
            this.siguienteTarea = siguienteTarea;
        }
        

    }
}
