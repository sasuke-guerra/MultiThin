using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea.Models
{
    static class Algo
    {

       public static List<Tareas> LTareas = new List<Tareas>();
    }

    public class Tareas
    {
        public string Materia { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
    }
}