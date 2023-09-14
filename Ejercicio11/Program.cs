using System;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Construir un algoritmo que pida N números por pantalla, cuando el usuario ingrese un número negativo, el programa debe finalizar y mostrar en consola la cantidad total de números positivos que ingresó hasta antes de ingresarse el número negativo. 

            //Declaración de variables
            int contador = 0;
            int num;
            bool isPositivo = true;

            do
            {
                Console.WriteLine("Ingresa un número: "); 
                num = Convert.ToInt32(Console.ReadLine()); //num = -2

                if (num >= 0)
                {
                    contador++; // contador = 3
                }
                else
                {
                    isPositivo = false;
                }

            } while (num >= 0);


            //SOLUCIÓN ALTERNA
            //Console.WriteLine("Ingresa un número: ");
            //num = Convert.ToInt32(Console.ReadLine());

            //while (num >= 0)
            //{
            //    contador++;
            //    Console.WriteLine("Ingresa otro número: ");
            //    num = Convert.ToInt32(Console.ReadLine());
            //}

            Console.WriteLine(String.Format("La cantidad de números positivos es de {0}", contador));
        }
    }
}
