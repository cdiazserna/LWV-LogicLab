using System;
using System.Data;

namespace Ejercicio39_BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrolle un algoritmo donde almacene las ventas que obtuvo mensualmente un almacén durante el año 2022. Mostrar por pantalla el total de ventas.

            //Declaración de variables:
            string[] months = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            decimal[] sales = new decimal[12]; //Declaración del array
            decimal totalSales = 0, aux = 0;

            //Con este FOR ingreso las ventas mes a mes
            for (int i = 0; i < sales.Length; i++)
            {
                Console.WriteLine(String.Format("Ingrese las ventas del mes {0}", months[i]));
                //Estoy validando que el valor que yo ingrese de ventas, sea un número positivo
                while (!decimal.TryParse(Console.ReadLine(), out sales[i]) || sales[i] < 0)
                {
                    Console.Write("Por favor ingrese un número válido y positivo: ");
                }
                totalSales += sales[i]; //Forma de sumar venta tras venta.
            }

            //Console.Clear();
            Console.WriteLine(String.Format("Total ventas año 2022: {0:N2}", totalSales));

            //Esto es temporal: for para llenar el array
            //for (int i = 0; i < sales.Length; i++)
            //{
            //    Console.WriteLine(String.Format("Ingrese valor de la posición {0}", i));
            //    sales[i] = Convert.ToDecimal(Console.ReadLine());
            //}

            //Método Burbuja - Bubble Sort
            for (int i = 0; i < sales.Length - 1; i++) //   |2|5|1|5| array --- 3 < 4 overflow  desbordamiento de índice
            {
                for (int j = 0; j < sales.Length - 1 - i; j++)  // |2|5|1|5| cuando i = 0, j=0,  0 < 3
                {
                    if (sales[j] > sales[j + 1])
                    {
                        //Aplico el patrón de intercambio de posiciones
                        aux = sales[j];
                        sales[j] = sales[j + 1];
                        sales[j + 1] = aux;
                    }
                }
            }

            //Loop to show the array
            for (int i = 0; i < sales.Length; i++)
            {
                Console.WriteLine(String.Format("Posición {0} = {1}", i, sales[i]));
            }

            //FORMA MENOS EFICIENTE
            ////3 menores ventas:
            //Console.WriteLine("Venta menor: " + sales[0]);
            //Console.WriteLine("Venta menor: " + sales[1]);
            //Console.WriteLine("Venta menor: " + sales[2]);

            ////3 mayores ventas:
            //Console.WriteLine("Venta mayor: " + sales[9]);
            //Console.WriteLine("Venta mayor: " + sales[10]);
            //Console.WriteLine("Venta mayor: " + sales[11]);

            //FORMA MÁS EFICIENTE
            //3 menores ventas
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Venta menor en la posicion {i} = {sales[i]}");
            }

            Console.WriteLine(" ");

            //3 mayores ventas
            for (int i = sales.Length - 1; i > sales.Length - 4; i--)
            {
                Console.WriteLine($"Venta mayor en la posicion {i} = {sales[i]}");
            }
        }
    }
}
