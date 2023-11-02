using System;

namespace Ejercicio41_ArrayPromedios
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[5];
            double suma = 0;

            Console.WriteLine("Ingrese las notas de los estudiantes:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Estudiante {i + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out notas[i]) || notas[i] < 0 || notas[i] > 5)
                {
                    Console.Write("Entrada inválida. Por favor, ingrese un número entre 0 y 5: ");
                }
                suma += notas[i];
            }

            for (int i = 0; i < notas.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < notas.Length; j++)
                {
                    if (notas[j] < notas[minIndex])
                    {
                        minIndex = j;
                    }
                }

                double temp = notas[minIndex];
                notas[minIndex] = notas[i];
                notas[i] = temp;
            }

            double promedio = suma / 5;

            Console.WriteLine("\nNotas ordenadas de menor a mayor:");

            foreach (double nota in notas)
            {
                if (nota < 3.0) Console.ForegroundColor = ConsoleColor.Red;
                else Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(nota);
            }

            Console.ResetColor();
            Console.WriteLine($"\nPromedio general: {promedio}");
        }
    }
}