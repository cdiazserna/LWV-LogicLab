using System;

namespace Ejercicio40_SelectionSortArray
{
    public class Program
    {
        static void Main()
        {
            //Realizar un algoritmo que me pida por pantalla la cantidad de números naturales que desea ingresar para guardarlos en un array. Luego de conocer la longitud del array y llenarlo con los números, el algoritmo deberá ordenarlos con el método de selección. Mostrar en pantalla el arreglo ordenado ascendentemente (menor a mayor). 

            //Declaración de variables globales
            int n, minIndex = 0, aux = 0, swt;
            bool retornar;
            do
            {
                //Pedimos la longitud del array
                Console.Write("Ingrese la cantidad de números naturales para el array: ");
                n = int.Parse(Console.ReadLine());

                //Declaramos el nuevo array
                int[] numbers = new int[n];

                //Lo llenamos con N
                for (int i = 0; i < n; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(String.Format("Ingrese el número en la posición {0}: ", i + 1));
                    numbers[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("\n");
                //Esta es la forma más efectiva y rápida de organizar un array con un método propio de .Net: Sort()
                //Array.Sort(numbers); // PROHIBIDO USARLA

                //Organizar con el método de "Selection Sort"
                for (int i = 0; i < n - 1; i++)
                {
                    //i = 3
                    //Var para comenzar la comparación entre el índice menor y siguiente
                    minIndex = i;
                    for (int j = i + 1; j < n; j++)
                        if (numbers[j] < numbers[minIndex]) //Comparo las dos posiciones
                            minIndex = j; //le asigno la posición que tiene el menor valor al minIndex

                    //Aquí valido que efectivamente sean diferentes para intercambiar valores entre esas 2 posiciones.
                    if (i != minIndex)
                    {
                        aux = numbers[i];
                        numbers[i] = numbers[minIndex];
                        numbers[minIndex] = aux;
                    }
                }

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Array ordenado de menor a mayor:");
                //mostrar array ordenado
                for (int i = 0; i < n; i++)
                    Console.WriteLine(numbers[i]);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nDigite 1 para volver al inicio, o 0 para terminar");
                swt = int.Parse(Console.ReadLine());
                if (swt == 1)
                    retornar = true;
                else
                    retornar = false;

                Console.Clear();
            }
            while (retornar);
        }
    }
}
