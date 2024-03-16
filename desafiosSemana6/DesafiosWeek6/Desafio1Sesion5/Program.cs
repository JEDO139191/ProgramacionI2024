using Desafio1Sesion5;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear un rectángulo
        Rectangulo rectangulo = new Rectangulo(5, 10);

        // Acceder a la superficie frontal (solo lectura)
        Console.WriteLine("Superficie frontal: " + rectangulo.SuperficieFrontal);
    }
}