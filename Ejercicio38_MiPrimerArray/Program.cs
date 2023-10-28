using System;

namespace Ejercicio38_MiPrimerArray
{
        public class Program
        {
            static void Main(string[] args)
            {
                //Desarrolle un algoritmo donde almacene las ventas que obtuvo mensualmente un almacén durante el año 2022. Mostrar por pantalla el total de ventas.

                //Declaración de variables:
                string[] months = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
                decimal[] sales = new decimal[12]; //Declaración del array
                decimal totalSales = 0;

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

                Console.Clear();
                Console.WriteLine(String.Format("Total ventas año 2022: {0:N2}", totalSales));

            }
        }
    }
