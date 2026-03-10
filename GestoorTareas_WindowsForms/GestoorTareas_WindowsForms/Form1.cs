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
            string categoria = cmbCategoria.SelectedItem?.ToString() ?? "Sin categoría";

            gestor.AgregarTarea(textBoxNombre.Text, textBoxDescripcion.Text, dateTimePicker1.Value, categoria);//agrega el elemento con cada cosa q pide el constructor
            textBoxNombre.Clear();//limpia el hueco para el tit y descr
            textBoxDescripcion.Clear();
            ActualizarLista();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxTareas.SelectedItem != null)//validar si estб seleccionado el elemento o no
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
            var tareas = gestor.ObtenerTareas(); 
            foreach (var tarea in tareas)
                listBoxTareas.Items.Add(tarea.ToString());

            lblContadorTareas.Text = $"Total de tareas: {tareas.Count}";
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

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //filtrarlos
            string seleccion = cmbCategoria.SelectedItem?.ToString();
            var filtradas = gestor.ObtenerTareas()
                                   .Where(t => t.Categoria == seleccion)
                                   .ToList();

            listBoxTareas.Items.Clear();
            foreach (var tarea in filtradas)
                listBoxTareas.Items.Add(tarea);
        }

        private void lblContadorTareas_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
