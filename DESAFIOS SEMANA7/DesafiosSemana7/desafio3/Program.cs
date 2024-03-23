using System;

class Program
{
    static string[] listaTareas = new string[10]; 
    static int contadorTareas = 0;

    static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n----- Menú -----");
            Console.WriteLine("1. Mostrar lista de tareas");
            Console.WriteLine("2. Agregar nueva tarea");
            Console.WriteLine("3. Eliminar tarea");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    MostrarListaTareas();
                    break;
                case "2":
                    AgregarTarea();
                    break;
                case "3":
                    EliminarTarea();
                    break;
                case "4":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción inválida. Inténtelo de nuevo.");
                    break;
            }
        }
    }

    static void MostrarListaTareas()
    {
        if (contadorTareas == 0)
        {
            Console.WriteLine("La lista de tareas está vacía.");
        }
        else
        {
            Console.WriteLine("----- Lista de Tareas -----");
            for (int i = 0; i < contadorTareas; i++)
            {
                Console.WriteLine($"{i + 1}. {listaTareas[i]}");
            }
        }
    }

    static void AgregarTarea()
    {
        if (contadorTareas < listaTareas.Length)
        {
            Console.Write("Ingrese la nueva tarea: ");
            string nuevaTarea = Console.ReadLine();
            listaTareas[contadorTareas] = nuevaTarea;
            contadorTareas++;
            Console.WriteLine("Tarea agregada correctamente.");
        }
        else
        {
            Console.WriteLine("No se pueden agregar más tareas. Límite alcanzado.");
        }
    }

    static void EliminarTarea()
    {
        if (contadorTareas == 0)
        {
            Console.WriteLine("No hay tareas para eliminar.");
        }
        else
        {
            Console.WriteLine("Seleccione el número de la tarea que desea eliminar:");
            for (int i = 0; i < contadorTareas; i++)
            {
                Console.WriteLine($"{i + 1}. {listaTareas[i]}");
            }

            int indice;
            do
            {
                Console.Write("Índice de la tarea a eliminar: ");
            } while (!int.TryParse(Console.ReadLine(), out indice) || indice < 1 || indice > contadorTareas);

            for (int i = indice - 1; i < contadorTareas - 1; i++)
            {
                listaTareas[i] = listaTareas[i + 1];
            }
            contadorTareas--;
            Console.WriteLine("Tarea eliminada correctamente.");
        }
    }
}
