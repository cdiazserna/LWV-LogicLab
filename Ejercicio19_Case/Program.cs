using System;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace Ejercicio19_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realice un programa que solicite dos números, luego debe pedirse un número que seleccionará alguna operación aritmética desde un menú. Si introduce 1 los números se deben sumar, si introduce 2 los números se deben restar, si es 3 los números se multiplican y si introduce 4 los números se dividen (validar división por cero). Independientemente de la selección, imprima el resultado. Además, el programa debe tener la posibilidad de volver al menú para pedir 2 nuevos números y hacer la elección de la operación aritmética o digitar cero/no para finalizar el programa.

            //Datos de entrada
            double num1, num2, resultado = 0;
            int opcion, validar;
            bool retornar = true;

            while (retornar)
            {
                Console.Clear();
                Console.WriteLine("Ingrese los dos números: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("---Menú de Operaciones Aritméticas---");
                Console.WriteLine("- Seleccione una opción:            -");
                Console.WriteLine("- 1. Sumar                          -");
                Console.WriteLine("- 2. Restar                         -");
                Console.WriteLine("- 3. Multiplicar                    -");
                Console.WriteLine("- 4. Dividir                        -");
                Console.WriteLine("- 0. Finalizar                      -");
                Console.WriteLine("-------------------------------------");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 0:
                        retornar = false;
                        break;
                    case 1:
                        Console.WriteLine($"Suma:¨{num1 + num2}");
                        Console.WriteLine("Presione 1 para volver");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine($"Resta:¨{num1 - num2}");
                        Console.WriteLine("Presione 1 para volver");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine($"Multiplicación:¨{num1 * num2}");
                        Console.WriteLine("Presione 1 para volver");
                        Console.ReadKey();
                        break;

                    case 4:
                        if (num1 == 0 && num2 == 0) Console.WriteLine($"División por cero indeterminada");
                        else if (num1 >= num2) Console.WriteLine($"División:{num2 / num1}");
                        else Console.WriteLine($"División:¨{num1 / num2}");
                        Console.WriteLine("Presione 1 para volver");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine($"Ingrese una opción válida. Digite ENTER para continuar.\n");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
