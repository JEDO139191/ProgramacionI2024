using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Finanzas
    {
        public static void CalcularIngresos(string nombreUsuario)
        {
            int ingresosMes1, ingresosMes2, ingresosMes3;

           
            Console.WriteLine("Ingrese los ingresos del primer mes:");
            ingresosMes1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los ingresos del segundo mes:");
            ingresosMes2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los ingresos del tercer mes:");
            ingresosMes3 = int.Parse(Console.ReadLine());

           
            int suma = ingresosMes1 + ingresosMes2 + ingresosMes3;

        
            double promedio = suma / 3;

         
            Console.WriteLine($"Hola {nombreUsuario}, en total ganaste {suma} y promediaste {promedio}.");
        }
    }
}

