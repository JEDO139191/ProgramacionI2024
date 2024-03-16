using System;

namespace Programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int suma=0;
            int contador = 0;
            double promedio;

            Console.WriteLine("Digite el numero 0 para salir del programa");
            do
            {
                
                Console.WriteLine("Digite un numero");
                numero = Convert.ToInt32(Console.ReadLine());
                suma +=numero;
                if(numero!=0)contador ++;


            } while (numero != 0);

            promedio = suma / contador;

            Console.WriteLine($"La suma de los numero es {suma} y el promedio de la suma es {promedio}");
        }
    }
}