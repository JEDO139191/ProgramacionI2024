using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1
{
    internal class Operaciones
    {
        int saldo;
        int retirar;
        int deposito;
        public void ConsultaDinero()
        {
            Console.WriteLine(saldo);
         }

        public void depositarDinero()
        {
            Console.WriteLine("Ingrese la cantidad que desea depositar");
            deposito += saldo;
        }

        public void retirarDinero()
        {
            Console.WriteLine("Ingrese la cantidad que desea retirar");
            if (retirar > saldo) 
            {
                Console.WriteLine("No hay fondos suficientes");
            }
            else
            {
                saldo -= retirar;
            }
            

        }

        /* public int consultaDinero(int saldo )
        {
            return consultaDinero(saldo);
        }

        public int retirarDinero(int saldo, int retiro)
        {
            return saldo - retiro;
        }

        public int depositarDinero( int saldo, int deposito )
        {
            return saldo+deposito;
        }
        */

    }
}
