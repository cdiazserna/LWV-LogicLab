using System;

namespace Ejercicio46_Matrices
{
    public class Program
    {
        ///Crear un algoritmo en C# que me declare una matriz de dimensiones 2x4. El programa me debe llenar la primera fila con números naturales aleatorios entre 1 y 10, luego debe llenar la segunda fila con el triple del número ubicado en su misma posición de columna, pero de la primera fila. Mostrar la matriz de 2x4 en pantalla. 
        static void Main(string[] args)
        {
            //Declaración e instanciación de la matriz
            int[,] matrix = new int[2,4];

            //Crear objeto del Random
            Random random = new Random();

            //Llenemos la primera fila
            for (int i = 0; i < 4; i++ )
            {
                matrix[0,i] = random.Next(1, 11);
            }

            //Llenamos la segunda fila:
            for (int i = 0; i < 4; i++)
            {
                matrix[1, i] = matrix[0, i] * 3;
            }

            Console.Write($"------ Matrix 2x4 -------\n");
            //Con estos dos Fors Anidados, MUESTRO la Matriz
            for (int f = 0; f < 2; f++ ) //COMIENZO CON LAS FILAS Fila = Row
            {
                for (int c = 0; c < 4; c++ ) // CONTINÚO CON LAS COLUMNAS
                {
                    Console.Write($"{matrix[f, c]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
