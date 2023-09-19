using System;

namespace Ejercicio14
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Elabora un algoritmo que imprima los números del 1 al 100. Que calcule la suma de todos los números pares por un lado, y por otro, la de todos los impares. 

            //Declaración de variables
            int sumaPares = 0, sumaImpares = 0;

            for (int i = 1; i <= 100; i++) //i++ --> i = i + 1
            {
                Console.Write($"{i} ");

                if (i % 2 == 0)
                {
                    sumaPares += i; // sumaPares = sumaPares + i
                }
                else
                {
                    sumaImpares += i; //sumaImpares = sumaImpares + i
                }
            }

            Console.WriteLine("\n");
            Console.Write(String.Format("La suma de los pares es = {0}", sumaPares));
            Console.WriteLine("\n");
            Console.Write(String.Format("La suma de los impares es = {0}", sumaImpares));
        }
    }
}
