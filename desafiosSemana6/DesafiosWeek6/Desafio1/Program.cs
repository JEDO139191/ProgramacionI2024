using System;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un número positivo");
            int num=Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                for (int i = 1; i <= num; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            } else
            {
                Console.WriteLine("Ha ingresado un número negativo");
            }
        }
    }
}