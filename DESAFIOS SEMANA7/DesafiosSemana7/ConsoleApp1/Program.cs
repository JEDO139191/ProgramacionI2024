using System;

class Program
{
    static char[,] tablero = new char[3, 3]; 
    static char jugadorActual = 'X'; 

    static void InicializarTablero()
    {
        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                tablero[i, j] = ' ';
            }
        }
    }

    static void DibujarTablero()
    {
        
        Console.WriteLine("  0 1 2");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i + " ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(tablero[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static bool MovimientoValido(int fila, int columna)
    {
        
        return (fila >= 0 && fila < 3 && columna >= 0 && columna < 3 && tablero[fila, columna] == ' ');
    }

    static bool TableroLleno()
    {
        
        foreach (char c in tablero)
        {
            if (c == ' ')
                return false;
        }
        return true;
    }

    static char VerificarGanador()
    {
        
        for (int i = 0; i < 3; i++)
        {
            if (tablero[i, 0] != ' ' && tablero[i, 0] == tablero[i, 1] && tablero[i, 1] == tablero[i, 2])
                return tablero[i, 0]; 
            if (tablero[0, i] != ' ' && tablero[0, i] == tablero[1, i] && tablero[1, i] == tablero[2, i])
                return tablero[0, i];
        }

        
        if (tablero[0, 0] != ' ' && tablero[0, 0] == tablero[1, 1] && tablero[1, 1] == tablero[2, 2])
            return tablero[0, 0]; 
        if (tablero[0, 2] != ' ' && tablero[0, 2] == tablero[1, 1] && tablero[1, 1] == tablero[2, 0])
            return tablero[0, 2]; 

        return ' '; 
    }

    static void Jugar()
    {
        int fila, columna;

        do
        {
            Console.WriteLine($"Turno del jugador {jugadorActual}.");
            Console.Write("Ingrese la fila: ");
            fila = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la columna: ");
            columna = int.Parse(Console.ReadLine());

            if (MovimientoValido(fila, columna))
            {
                tablero[fila, columna] = jugadorActual;
                DibujarTablero();
                if (VerificarGanador() != ' ' || TableroLleno())
                    break;
                jugadorActual = (jugadorActual == 'X') ? 'O' : 'X'; 
            }
            else
            {
                Console.WriteLine("Movimiento inválido. Inténtelo de nuevo.");
            }
        } while (true);

        
        char ganador = VerificarGanador();
        if (ganador != ' ')
            Console.WriteLine($"¡El jugador {ganador} ha ganado!");
        else
            Console.WriteLine("¡Empate!");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al juego ToTiTo (Tic Tac Toe) con arreglos multidimensionales.");
        InicializarTablero();
        DibujarTablero();
        Jugar();
    }
}