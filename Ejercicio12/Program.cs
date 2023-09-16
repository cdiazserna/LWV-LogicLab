using System;
using System.Reflection;

namespace Ejercicio12
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Programe un algoritmo que pida a usuario 2 números por pantalla y que muestre todos los números comprendidos entre ambos números incluyéndolos. 

            //Declaración de variables
            bool retorno = false;
            int num1, num2, min, max, numero;
            const string MESSAGE = "Por favor ingresar un número entero válido. Presione la tecla ENTER";

            do
            {
                Console.Clear();
                Console.Write("Ingrese el primer número: ");
                if (!int.TryParse(Console.ReadLine(), out num1)) //9
                {
                    Console.WriteLine(MESSAGE);
                    retorno = true;
                    Console.ReadKey();
                }
                else
                {
                    retorno = false;
                }
            }
            while (retorno);


            do
            {
                Console.Write("Ingrese el segundo número: ");
                if (!int.TryParse(Console.ReadLine(), out num2)) //9
                {
                    Console.WriteLine(MESSAGE);
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            }
            while (retorno);

            //Proceso
            min = Math.Min(num1, num2);
            max = Math.Max(num1, num2);

            numero = min;
            while (numero <= max)
            {
                Console.Write(String.Format("{0} ", numero));
                numero++;
            }
        }
    }
}
