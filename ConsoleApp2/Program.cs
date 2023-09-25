using System;

namespace AdivinaElNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int minPlayers = 2, maxPlayers = 4;
            bool playAgain = true, hasWon = false;
            Random random = new Random();

            while (playAgain)
            {
                Console.Write("Ingrese el número de jugadore, mínimo 2 y máximo 4: ");
                int numPlayers = Convert.ToInt32(Console.ReadLine());

                if (numPlayers < minPlayers || numPlayers > maxPlayers)
                {
                    Console.WriteLine("Número de jugadores inválido. Intenta de nuevo.");
                    continue;
                }

                int upperBound;

                if (numPlayers == 2) upperBound = 50;
                else if (numPlayers == 3) upperBound = 100;
                else upperBound = 200;

                int randomNumber = random.Next(0, upperBound + 1);

                while (!hasWon)
                {
                    for (int i = 1; i <= numPlayers; i++)
                    {
                        Console.WriteLine($"Turno del Jugador {i}:");
                        Console.Write("Ingresa tu número: ");
                        int playerGuess = Convert.ToInt32(Console.ReadLine());

                        if (playerGuess > randomNumber) Console.WriteLine("MENOR");
                        else if (playerGuess < randomNumber) Console.WriteLine("MAYOR");
                        else
                        {
                            Console.WriteLine("¡HAS GANADO!");
                            hasWon = true;
                            break;
                        }
                    }
                }

                Console.Write("¿Quieren jugar de nuevo? (s/n) --> ");
                string playAgainResponse = Console.ReadLine().ToLower();
                if (playAgainResponse != "s") playAgain = false;
            }
        }
    }
}