using System;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número positivo");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 1) 
            {
                bool esPrimo = true; 

                for (int i = 2; i < num; i++) 
                {
                    if (num % i == 0) 
                    {
                        esPrimo = false;
                        break;
                    }
                }

                
                if (esPrimo)
                {
                    Console.WriteLine("Es primo");
                }
               
            }
            else
            {
                Console.WriteLine("Ha ingresado un número no válido");
            }
        }
    }
}