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

        public void AgregarTarea(string nombre, string descripcion, DateTime fecha)
        {
            tareas.Add(new Tarea(nombre, descripcion, fecha));
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

        public List<Tarea> ObtenerTareas()
        {
            return new List<Tarea>(tareas);
        }
    }
}
