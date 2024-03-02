/*Crea un sistema de inicio de sesión de usuario, 
 * donde el usuario puede primero registrarse y luego iniciar sesión.
 * El programa debe verificar si el usuario ha ingresado el nombre de usuario
 * y la contraseña correctos al iniciar sesión (por lo tanto, los mismos que utilizó al registrarse).
Utiliza declaraciones If, ingresos del usuario y métodos para resolver el desafío.*/
using static Desafio1.Usuarios;
using System;
GestorUsuarios gestorUsuarios = new GestorUsuarios();

while (true)
{
    Console.WriteLine("\nSeleccione una opción:");
    Console.WriteLine("1. Registrarse");
    Console.WriteLine("2. Iniciar sesión");
    Console.WriteLine("3. Salir");

    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.Write("Ingrese su nombre de usuario: ");
            string nombreRegistro = Console.ReadLine();
            Console.Write("Ingrese su contraseña: ");
            string contraseñaRegistro = Console.ReadLine();
            gestorUsuarios.RegistrarUsuario(nombreRegistro, contraseñaRegistro);
            break;
        case "2":
            Console.Write("Ingrese su nombre de usuario: ");
            string nombreInicio = Console.ReadLine();
            Console.Write("Ingrese su contraseña: ");
            string contraseñaInicio = Console.ReadLine();
            gestorUsuarios.IniciarSesion(nombreInicio, contraseñaInicio);
            break;
        case "3":
            Console.WriteLine("¡Hasta luego!");
            return;
        default:
            Console.WriteLine("Opción no válida. Por favor, seleccione nuevamente.");
            break;
    }
}