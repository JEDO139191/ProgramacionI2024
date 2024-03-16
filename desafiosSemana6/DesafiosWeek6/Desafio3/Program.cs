using System;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese las notas del estudiante. Cuando termine, escriba 'fin' para saber el promedio.");

            int totalPuntos = 0;
            int contador = 0;

            do
            {
                try
                {
                    string entrada = Console.ReadLine();

                    
                    if (entrada.ToLower() == "fin")
                    {
                        if (contador == 0)
                        {
                            Console.WriteLine("No se han ingresado calificaciones.");
                        }
                        else
                        {
                            double promedio = (double)totalPuntos / contador;
                            Console.WriteLine("El puntaje promedio es: " + promedio.ToString("0.00"));
                        }
                        break;
                    }

                    int calificacion = int.Parse(entrada);

                   
                    if (calificacion >= 1 && calificacion <= 10)
                    {
                        totalPuntos += calificacion;
                        contador++;
                    }
                    else
                    {
                        Console.WriteLine("El puntaje debe estar entre 1 y 10.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido o 'fin' para terminar.");
                }
            } while (true);
        }
    }
}