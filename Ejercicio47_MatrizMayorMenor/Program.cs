using System;

namespace Ejercicio47_MatrizMayorMenor
{
    public class Program
    {
        //Crear una matriz de nxm, llenarla con números naturales por pantalla e imprimir el menor y el mayor número, además de mostrar en qué posición se encuentran ambos números. 
        static void Main(string[] args)
        {
            //Solicitud de n y m
            Console.Write("Ingrese el número de filas: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columnas: ");
            int columns = int.Parse(Console.ReadLine());

            //Declaración de la matriz y variables
            int[,] matrix = new int[rows, columns];


            //Llenado de la matriz
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    Console.Write(String.Format("Ingrese el número natural en la posición [{0},{1}]", r, c));
                    matrix[r,c] = int.Parse(Console.ReadLine());
                }
            }

            int maxValue = matrix[0, 0], minValue = matrix[0, 0], minRow = 0, minCol = 0, maxCol = 0, maxRow = 0;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (matrix[r, c] < minValue)
                    {
                        minValue = matrix[r, c];
                        minRow = r;
                        minCol = c;
                    }

                    if (matrix[r,c] > maxValue)
                    {
                        maxValue = matrix[r, c]; //maxValue = 9
                        maxRow = r;
                        maxCol = c;
                    }
                }
            }

            //Mostrar valores
            Console.WriteLine(String.Format("El número mayor es {0} y está en la posición [{1},{2}]", maxValue, maxRow, maxCol));
            Console.WriteLine(String.Format("El número menor es {0} y está en la posición [{1},{2}]", minValue, minRow, minCol));
        }
    }
}
