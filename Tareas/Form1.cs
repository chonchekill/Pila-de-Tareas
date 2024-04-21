using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tareas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        listaEnlazada listaEnlazada = new listaEnlazada();

        private void button1_Click(object sender, EventArgs e)
        {
            int idTarea = int.Parse(textBox1.Text);
            string descripcionTarea = textBox3.Text;
            if (idTarea != 0 && descripcionTarea != "") 
            { 
                textBox4.Text = "";
                textBox5.Text = "";
                textBox2.Text = "";
                listaEnlazada.agregarTarea(idTarea, descripcionTarea,false,null);
                listaEnlazada.mostrarTareas(listaEnlazada.primeraTarea,textBox2);
                listaEnlazada.Mostrarestado(listaEnlazada.primeraTarea, textBox4, textBox5);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox2.Text = "";
            int Idtarea = int.Parse(textBox6.Text);
            listaEnlazada.terminarTarea(listaEnlazada.primeraTarea, Idtarea);
            listaEnlazada.mostrarTareas(listaEnlazada.primeraTarea, textBox2);
            listaEnlazada.Mostrarestado(listaEnlazada.primeraTarea, textBox4, textBox5);
        }


    }
}
