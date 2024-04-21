using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tareas
{
    internal class listaEnlazada
    {

        public Tarea primeraTarea;

        public void agregarTarea (int idTarea, string descripcionTarea, bool estado, Tarea siguienteTarea)
        {
            if (primeraTarea == null)
            {
                Tarea tarea = new Tarea(idTarea, descripcionTarea, estado, siguienteTarea);
                primeraTarea = tarea;
            }
            else
            {
                Tarea aux = buscarUltima(primeraTarea);
                aux.siguienteTarea = new Tarea (idTarea,descripcionTarea,estado, siguienteTarea);
            }
        }
        private Tarea buscarUltima(Tarea tarea)
        {
            if (tarea.siguienteTarea == null)
            {
                return tarea;
            }
            else
                return buscarUltima(tarea.siguienteTarea);

        }
        private Tarea buscarTarea(Tarea Tarea, int idtarea)
        {
            if (Tarea != null)
            {
                if (Tarea.idTarea == idtarea)
                {
                    return Tarea;
                }
                else
                {
                    return buscarTarea(Tarea.siguienteTarea, idtarea);
                }
            }
            return null;
        }    
        public void mostrarTareas(Tarea Tarea,TextBox textBox2)
        {
            if(Tarea != null)
            {
                textBox2.Text += Tarea.idTarea.ToString() + " " + Tarea.descripcionTarea + " " + Tarea.estadoTarea.ToString() + " - " + Environment.NewLine;
                mostrarTareas(Tarea.siguienteTarea, textBox2);  
            }
        }

        public void Mostrarestado(Tarea Tarea, TextBox textBox4, TextBox textBox5)
        {
            if (Tarea != null)
            {
                if (Tarea.estadoTarea == true)
                {
                    textBox4.Text += Tarea.idTarea.ToString() + " " + Tarea.descripcionTarea + " " + Tarea.estadoTarea.ToString() + " - " + Environment.NewLine;
                    Mostrarestado(Tarea.siguienteTarea, textBox4,textBox5);
                }
                else
                {
                    textBox5.Text += Tarea.idTarea.ToString() + " " + Tarea.descripcionTarea + " " + Tarea.estadoTarea.ToString() + " - " + Environment.NewLine;
                    Mostrarestado(Tarea.siguienteTarea, textBox4, textBox5);
                }

            }
        }

        public void terminarTarea(Tarea Tarea, int Idtarea)
        {

            Tarea aux = buscarTarea(Tarea, Idtarea);
            if (aux != null)
            {
                aux.estadoTarea = true;
            }
        }
    }
}
