using System;

namespace Ejercicio49_TableroX
{
    public class Program
    {
        //En C# hacer un tablero que se llene con el caracter "X" y en la posición [0,0] haya una "O". Hacer un menú con 5 opciones (derecha, izquierda, arriba, abajo, salir), crear la funcionalidad de poder mover el "O" por todo el tablero usando las teclas de dirección. No está permitido que el “O” se salga del tablero, simplemente el programa debe omitir ese movimiento. 
        static void Main(string[] args)
        {
            char[,] board = new char[5, 5];
            int posX = 0, posY = 0;

            bool escKeyPressed = false;

            //Primero debo llenar mi matriz (board)
            for (int f = 0; f < 5; f++)
                for (int c = 0; c < 5; c++)
                    board[f, c] = 'X';

            board[posX, posY] = 'O';

            //Segundo, muestro el Board
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                    Console.Write(board[f, c] + " ");
                Console.WriteLine();
            }

            while (!escKeyPressed) 
            { 
                
            }
        }
    }
}