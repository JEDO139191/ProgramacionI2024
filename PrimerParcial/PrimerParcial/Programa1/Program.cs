//variables saldo
//acciones depositar, verificar, retirar y salir del programa

using System;
using static Programa1.Operaciones;
namespace Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion=0;
            int saldo = 0;
            int retirar = 0;
            int depositar = 0;
            Console.WriteLine("Bienvendos a BanUMG");
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Consulta Saldo");
                Console.WriteLine("2. Depositar");
                Console.WriteLine("3. Retira");
                Console.WriteLine("4. Salir");
                opcion=int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Operaciones misOperaciones();
                    misOperaciones = new Operaciones();
                }

               
                

            } while (opcion != 4);
        }
       
        
    }

    class Operaciones
    {
        public void ConsultaDinero(int saldo)
        {
            Console.WriteLine(saldo);
        }

        public void depositarDinero(int deposito, int saldo)
        {
            Console.WriteLine("Ingrese la cantidad que desea depositar");
            deposito += saldo;
        }

        public void retirarDinero(int retirar, int saldo)
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
    }
}