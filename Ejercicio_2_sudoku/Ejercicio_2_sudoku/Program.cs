using System;

namespace SudokuJugableConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tablero = GenerarSudokuJugable();
            int[,] tableroSolucion = new int[9, 9];
            Array.Copy(tablero, tableroSolucion, tablero.Length);

            ImprimirSudoku(tablero);

            while (!SudokuResuelto(tablero))
            {
                Console.Write("Ingresa la fila (1-9): ");
                int fila = int.Parse(Console.ReadLine()) - 1;

                Console.Write("Ingresa la columna (1-9): ");
                int columna = int.Parse(Console.ReadLine()) - 1;

                Console.Write("Ingresa el número (1-9): ");
                int numero = int.Parse(Console.ReadLine());

                if (EsMovimientoValido(tableroSolucion, fila, columna, numero))
                {
                    tablero[fila, columna] = numero;
                    ImprimirSudoku(tablero);
                }
                else
                {
                    Console.WriteLine("Movimiento no válido. Intenta de nuevo.");
                }
            }

            Console.WriteLine("¡Felicidades! ¡Has resuelto el sudoku!");
        }

        static int[,] GenerarSudokuJugable()
        {
            int[,] tablero = new int[9, 9];


            return tablero;
        }

        static void ImprimirSudoku(int[,] tablero)
        {
            for (int fila = 0; fila < 9; fila++)
            {
                for (int columna = 0; columna < 9; columna++)
                {
                    Console.Write(tablero[fila, columna] == 0 ? "  " : tablero[fila, columna] + " ");
                    if (columna == 2 || columna == 5)
                        Console.Write("| ");
                }
                Console.WriteLine();
                if (fila == 2 || fila == 5)
                    Console.WriteLine("---------------------");
            }
        }

        static bool SudokuResuelto(int[,] tablero)
        {
           
            return false;
        }

        static bool EsMovimientoValido(int[,] tablero, int fila, int columna, int numero)
        {
         
            return true;
        }
    }
}
