using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Tareas
{
    class Dato
    {
        //Atributos de las tareas
        public int id { get; set; }
        //Nombre que tendra la tarea
        public string Nombre { get; set; }
        //Descripcion de como realizar la tarea
        public string Descrip { get; set; }
        //Hora en que se realizara
        public string Hora { get; set; }
        //Fecha en que se llevara acabo
        public DateTime Fecha { get; set; }
        //Si la tarea esta en proceso o no
        public string Status { get; set; }
    }
}
