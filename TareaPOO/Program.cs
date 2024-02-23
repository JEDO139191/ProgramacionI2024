using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil c = new Automovil(1, "BMW", "4", 100, 12000);
            Console.WriteLine(c.ToString());

            AutomovilDeportivo d = new AutomovilDeportivo(2, "Ferrari", "GT", 50, 150000);
            Console.WriteLine(d.ToString());

            Console.ReadLine();
        }
    }
}
