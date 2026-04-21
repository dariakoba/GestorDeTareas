using System;

namespace GestorTareas_WindowsForms
{
    public class Tarea
    {
        public string Nombre { get; set; }//getters y setters típicos de c#
        public string Descripcion { get; set; }

        public List<string> Etiquetas { get; set; } = new List<string>(); // Nueva propiedad
        public DateTime FechaVencimiento { get; set; }
        public bool Completada { get; private set; }
        public bool PrioridadAlta { get; set; }
        public string Categoria { get; set; }

        public Tarea(string nombre, string descripcion, DateTime fechaVencimiento, string categoria)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            FechaVencimiento = fechaVencimiento;
            Categoria = categoria;
            Completada = false;
        }
        //código reutilizado

        public bool MarcarCompleta()
        {
            if (!Completada)
            {
                Completada = true;
                return true;
            }
            return false;
        }

        public string VerEstado()
        {
            return Completada ? "completada" : "no completada";
        }

        public override string ToString()
        {//le fecha de vencimiento en formato corto
            string prioridad = PrioridadAlta ? " | PRIORIDAD ALTA" : "";
            return $"{Nombre} | {Descripcion} | {Categoria} | Vence: {FechaVencimiento.ToShortDateString()} | {VerEstado() }{(PrioridadAlta ? " | " + prioridad : "")}";
        }
    }
}
