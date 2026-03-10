using System;
using System.Collections.Generic;

namespace GestorTareas_WindowsForms
{
    public class GestorDeTareas
    {
        private List<Tarea> tareas;

        public GestorDeTareas()
        {
            tareas = new List<Tarea>();
        }

        public void AgregarTarea(string nombre, string descripcion, DateTime fecha, string categoria)
        {
            tareas.Add(new Tarea(nombre, descripcion, fecha, categoria));
        }

        public void EliminarTareaPorNombre(string nombre)
        {
            tareas.RemoveAll(t => t.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));//elimina todos q coinciden con el nombre mayus o minus
        }

        public void CompletarTareaPorNombre(string nombre)
        {
            var tarea = tareas.Find(t => t.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));//lo encuentra y después lo marca
            tarea?.MarcarCompleta();
        }
        public void MarcarPrioridadAlta(string nombre, bool prioridadAlta)
        {
            var tarea = tareas.FirstOrDefault(t => t.Nombre == nombre);//Busca el primer elemento, como el find en js
            if (tarea != null)
            {
                tarea.PrioridadAlta = prioridadAlta;
            }
        }
        public List<Tarea> ObtenerTareas()
        {
            return new List<Tarea>(tareas);
        }
    }
}
