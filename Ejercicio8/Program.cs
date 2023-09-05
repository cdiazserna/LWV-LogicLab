using System;

namespace Ejercicio8
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Construir un programa que pida un número y luego diga si este número es par o no. 

            //Datos de Entrada: int num
            //Proceso % Módulo
            //Datos de salida: Solo mensaje

            //Declaración de variables:
            int num;
            bool esPar = false;

            Console.Write("Ingrese número: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0 ) //num = 5
            {
                esPar = true; 
            }

            if (esPar) // [if (!esPar)] -es igual a- [if (esPar == false)]
            {
                Console.WriteLine($"El número {num} es PAR");
            }
            else
            {
                Console.WriteLine($"El número {num} es IMPAR");
            }
        }
    }
}
