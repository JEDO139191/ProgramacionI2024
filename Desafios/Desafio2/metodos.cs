using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    internal class metodos
    {
        public class OperacionesBasicas
        {

            public static void Operaciones(int num1, int num2)
            {
                int suma = Sumar(num1, num2);
                int resta = Restar(num1, num2);
                int multiplicacion = Multiplicar(num1, num2);
                int division = Dividir(num1, num2);

                Console.WriteLine($"Suma: {num1} + {num2} = {suma}");
                Console.WriteLine($"Resta: {num1} - {num2} = {resta}");
                Console.WriteLine($"Multiplicación: {num1} * {num2} = {multiplicacion}");
                Console.WriteLine($"División: {num1} / {num2} = {division}");
            }

            
            private static int Sumar(int num1, int num2)=> num1 + num2;
            private static int Restar(int num1, int num2)=>num1 - num2;
            private static int Multiplicar(int num1, int num2)=> num1 * num2;    
            private static int Dividir(int num1, int num2)=> num1 / num2;
        }
    }
}

