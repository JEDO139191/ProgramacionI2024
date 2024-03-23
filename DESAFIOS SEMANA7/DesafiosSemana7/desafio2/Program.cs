using System;

class Program
{
    static void Main(string[] args)
    {
        
        double[,] montosCompras = {
            {120.50, 150.25, 200.75, 90.30, 180.60},
            {300.00, 80.50, 90.20, 1200.75, 500.00},
            {1500.00, 800.25, 650.50, 1200.00, 300.75},
            {80.00, 150.00, 220.50, 300.25, 400.75},
            {600.00, 750.00, 900.00, 1100.00, 1300.00}
        };

       
        CalcularTotalYDescuento(montosCompras);
    }

    static void CalcularTotalYDescuento(double[,] montos)
    {
        for (int i = 0; i < montos.GetLength(0); i++)
        {
            double totalCompra = 0;

          
            for (int j = 0; j < montos.GetLength(1); j++)
            {
                totalCompra += montos[i, j];
            }

            
            double descuento = 0;
            if (totalCompra >= 100 && totalCompra <= 1000)
            {
                descuento = totalCompra * 0.1; 
            }
            else if (totalCompra > 1000)
            {
                descuento = totalCompra * 0.2; 
            }

         
            Console.WriteLine($"Cliente {i + 1}: Total de compras = ${totalCompra}, Descuento = ${descuento}");
        }
    }
}
