using Practica1;
using System;

namespace Proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizarra pizarra1 = new Pizarra("blanco", 12, 4);
            pizarra1.Escribir("Hola estudiantes");

            Console.WriteLine(pizarra1.GetContenido());
            Console.ReadLine();
        }
    }
}