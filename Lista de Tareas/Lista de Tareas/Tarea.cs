using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Tareas
{
    //Herencia de atributos
    class Tarea:RepoTarea
    {
        //Es para dar la bienvenida
        public void principal()
        {

            Console.WriteLine("*-*Bienvenido a la lista de tareas *-*");
            Console.WriteLine("");

            Menu();
        }
        //Menu para llamar a los metodos, utilizando el switch
            private void Menu()
        {
            //Opciones de tarea
            Console.WriteLine("Ingrese el numero de opcion que desea:");
            Console.WriteLine("1.- Crear Tarea \n2.- Lista de Tareas \n3.- Detalle Tarea\n4.-Lista de Status\n5.-Salir");
            switch (Console.ReadLine())
            {
                case "1":
                    //Llamamos al metodo de Crear taras
                    Console.WriteLine("Crear Tarea:");
                    CrearTarea();
                    break;
                case "2":
                    //Se realiza el metodo de listar tareas
                    Console.WriteLine("Lista de Tareas:");
                    ListaTarea();
                    break;

                case "3":
                    //Se muestran los detalles que contiene la tarea en general
                    Console.WriteLine("Detalle Tarea:");
                    DetallesTarea();
                    break;

                case "4":
                    //Muestra el status de las tareas 
                    Console.WriteLine("Lista de Status:");
                    ListarStatus();
                    break;

                case "5":
                    //Se da salida al programa
                    Console.WriteLine("bye bye");
                    Environment.Exit(0);
                    break;

                default:
                    //Si se ingresa alguna opcion que no es la edecuada 
                    Console.WriteLine("No es valido");
                    break;
            }
            Console.Clear();
            Menu();

        }
       
    }
}
