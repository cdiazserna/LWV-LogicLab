using System;

//Un vendedor recibe un sueldo base más un 10% extra por comisión de sus ventas, el vendedor desea saber cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes y el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones. 

namespace Ejercicio3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            decimal sueldoBase, venta1, venta2, venta3, totalComision, totalSalario;

            //Declaración de constantes
            const decimal COMISION = 10/100;

            //Pedir los datos
            Console.Write("Ingrese su sueldo base: ");
            sueldoBase = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingrese su venta #1: ");
            venta1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingrese su venta #2: ");
            venta2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingrese su venta #3: ");
            venta3 = Convert.ToDecimal(Console.ReadLine());

        }
    }
}
