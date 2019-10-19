using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Tareas
{
    class RepoTarea
    { //Se instancia dato para hacer la lista de tareas
        List<Dato> lista = new List<Dato>();

        //Metodo para crear las tareas
        public void CrearTarea()
        {
            //Instanciar tarea
            Dato t = new Dato();
            //Ingreso de datos en los atributos
            Console.WriteLine("Ingrese Nombre:");
            t.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Descripcion de la tarea:");
            t.Descrip = Console.ReadLine();
            Console.WriteLine("Ingrese Hora:");
            t.Hora = Console.ReadLine();
            Console.WriteLine("Ingrese Fecha:");
            t.Fecha = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese status:");
            t.Status = Console.ReadLine();

            lista.Add(t);
            

        }
        //Metodo para Listar las tareas
        public void ListaTarea()
        {
            foreach (Dato x in lista)
            {
                Console.WriteLine(x.Nombre);
                Console.WriteLine("-");
                Console.ReadKey();

            }
        }
        //Metodo para ver los detalles de la tarea
        public void DetallesTarea()
        {
            //Utilizamos foreach para que se "recorrer" los elementos que utilizamos
            foreach (Dato d in lista)
            {
                Console.WriteLine("El detalle de la tarea " + d.Nombre + " es:\n" + d.Descrip);
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*");
                Console.WriteLine("");
                Console.ReadKey();
            }
           

        }
        //Metodo listar los status en que se encuentra la tarea
        public void ListarStatus()
        {
            //Utilizamos foreach para que se "recorrer" los elementos que utilizamos
            foreach (Dato m in lista)
            {
                Console.WriteLine(m.Nombre+":");
                Console.WriteLine(m.Status);
                Console.WriteLine("-");
                Console.ReadKey();

            }
        }
    }
}
