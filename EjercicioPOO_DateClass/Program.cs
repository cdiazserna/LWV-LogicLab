using System;

namespace EjercicioPOO_DateClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int dia, mes, ano;

            //Pedir datos por pantalla
            Console.Write("Ingrese el día: ");
            dia = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el mes: ");
            mes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el año: ");
            ano = Convert.ToInt32(Console.ReadLine());

            //Creación de objetos - Instancia de Clases
            MyDate myDate = new MyDate(dia, mes, ano);

            //Mostrar la fecha
            Console.WriteLine(myDate.ShowDate());
        }
    }
}
