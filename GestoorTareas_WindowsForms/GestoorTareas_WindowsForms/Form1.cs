using GestoorTareas_WindowsForms;
using System;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestorTareas_WindowsForms
{
    public partial class Form1 : Form
    {
        private GestorDeTareas gestor;

        public Form1()
        {
            InitializeComponent();
            gestor = new GestorDeTareas();
            ActualizarLista();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text)) return;//si no tiene nada escrito

            gestor.AgregarTarea(textBoxNombre.Text, textBoxDescripcion.Text, dateTimePicker1.Value);//agrega el elemento con cada cosa q pide el constructor
            textBoxNombre.Clear();//limpia el hueco para el tit y descr
            textBoxDescripcion.Clear();
            ActualizarLista();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxTareas.SelectedItem != null)//validar si está seleccionado el elemento o no
            {
                //obtener el nombre
                string nombre = listBoxTareas.SelectedItem.ToString().Split('|')[0].Trim();
                gestor.EliminarTareaPorNombre(nombre);
                ActualizarLista();
            }
            else
            {
                // si no ha sido seleccionado
                MessageBox.Show("Seleccione una tarea antes de eliminarla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void buttonCompletar_Click(object sender, EventArgs e)
        {
            if (listBoxTareas.SelectedItem == null) return;//si no esta, hace return

            string nombre = listBoxTareas.SelectedItem.ToString().Split('|')[0].Trim();
            gestor.CompletarTareaPorNombre(nombre);
            ActualizarLista();
        }

        private void ActualizarLista()
        {
            listBoxTareas.Items.Clear();
            foreach (var tarea in gestor.ObtenerTareas())
                listBoxTareas.Items.Add(tarea); // agrega el objeto
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblContadorTareas_Click(object sender, EventArgs e)
        {

        }
        
        private void chkPrioridadAlta_CheckedChanged(object sender, EventArgs e)
        {
            if (listBoxTareas.SelectedItem == null) return;

            var tarea = (Tarea)listBoxTareas.SelectedItem; // obtenemos el objeto directamente
            tarea.PrioridadAlta = chkPrioridadAlta.Checked; // marcamos la prioridad
            ActualizarLista(); // refresca la lista
        }
    }
}
