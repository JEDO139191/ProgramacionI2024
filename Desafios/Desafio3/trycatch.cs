using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3
{
    internal class tryCatch
    {
        public class Calculadora
        {
            public static void SumarValores()
            {
                try
                {
              
                    Console.WriteLine("Ingrese el primer valor:");
                    int valor1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo valor:");
                    int valor2 = int.Parse(Console.ReadLine());

                    
                    int suma = valor1 + valor2;

                 
                    Console.WriteLine($"La suma de {valor1} y {valor2} es: {suma}");
                }
                catch (FormatException)
                {
                  
                    Console.WriteLine("Error: Debe ingresar valores numéricos.");
                }
           
                finally
                {
                 
                    Console.WriteLine("Operación completada.");
                }
            }
        }
    }
}
