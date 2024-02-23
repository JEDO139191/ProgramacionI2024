using System;
using TareaPOO;

class Program
{
    static void Main(string[] args)
    {
        // Crear un objeto Rectangulo
        Rectangulo rectangulo1 = new Rectangulo(5, 10);

        // Calcular y mostrar el área
        double area = rectangulo1.CalcularArea();
        Console.WriteLine("Área del rectángulo: " + area);

        // Calcular y mostrar el perímetro
        double perimetro = rectangulo1.CalcularPerimetro();
        Console.WriteLine("Perímetro del rectángulo: " + perimetro);

        Console.ReadLine(); // Esperar a que el usuario presione Enter antes de salir
    }
}
