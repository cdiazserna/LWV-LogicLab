using System;

namespace Ejercicio49_TableroX
{
    public class Program
    {
        //Variables globales
        static char[,] board = new char[5, 5];
        static int posX = 0, posY = 0;

        //En C# hacer un tablero que se llene con el caracter "X" y en la posición [0,0] haya una "O". Hacer un menú con 5 opciones (derecha, izquierda, arriba, abajo, salir), crear la funcionalidad de poder mover el "O" por todo el tablero usando las teclas de dirección. No está permitido que el “O” se salga del tablero, simplemente el programa debe omitir ese movimiento. 
        static void Main(string[] args)
        {
            bool escKeyPressed = false;

            InitializeBoard();

            ShowBoard();

            while (!escKeyPressed) 
            {
                //ConsoleKeyInfo: Así es como declaro una variable que tenga la capacidad de almacenar el código de la tecla que tecleo.
                ConsoleKeyInfo keyPressed;

                Console.WriteLine("Usa las teclas de dirección para mover la 'O', o presiona la tecla 'Esc' para salir");
                Console.WriteLine("- Arriba");
                Console.WriteLine("- Abajo");
                Console.WriteLine("- Derecha");
                Console.WriteLine("- Izquierda");
                Console.WriteLine("Esc: Salir");
                keyPressed = Console.ReadKey();

                switch(keyPressed.Key)
                {
                    case ConsoleKey.RightArrow:
                        MoveO("derecha");
                        break;
                    case ConsoleKey.LeftArrow:
                        MoveO("izquierda");
                        break;
                    case ConsoleKey.UpArrow:
                        MoveO("arriba");
                        break;
                    case ConsoleKey.DownArrow:
                        MoveO("abajo");
                        break;
                    case ConsoleKey.Escape:
                        escKeyPressed = true;
                        break;
                }

                ShowBoard();
            }
        }

        private static void ShowBoard()
        {
            Console.Clear();
            Console.WriteLine("Mueva la bolita!\n");
            //Segundo, muestro el Board
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                    Console.Write(board[f, c] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void InitializeBoard()
        {
            //Primero debo llenar mi matriz (board)
            for (int f = 0; f < 5; f++)
                for (int c = 0; c < 5; c++)
                    board[f, c] = 'X';

            board[posX, posY] = 'O';

        }

        private static void MoveO(string direction)
        {
            board[posX, posY] = 'X'; //En la posición inicial debo de sobreescribir el O por la X

            switch (direction)
            {
                case "derecha":
                    if (posY < 4) posY++;
                    break;
                case "izquierda":
                    if (posY > 0) posY--;
                    break;
                case "abajo":
                    if (posX < 4) posX++;
                    break;
                case "arriba":
                    if (posX > 0) posX--;
                    break;
            }

            board[posX, posY] = 'O';
        }
    }
}