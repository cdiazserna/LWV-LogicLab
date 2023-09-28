using System;

namespace Ejercicio20_CaseRangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se quiere crear un algoritmo en C# que calcule el IMC de N pacientes y luego lo clasifique dentro de una categoría: 

            -Si el IMC del paciente es menor a 18,5, entonces tiene "peso insuficiente". 
            -Si el IMC está entre 18,5 y 24,9 se encuentre en la categoría de "Peso Saludable"
            -Si el IMC está entre 25,0 y 29,9 entonces tiene "sobrepeso"
            -Si el IMC es mayor de 29.9 entonces tiene "obesidad".

            Mostrar en pantalla la categoría de cada uno de los pacientes. La aplicación debe estar en capacidad de pedirle al usuario si quiere volver a calcular*/

            //Declaración de variables
            double peso, estatura, imc;
            int n;
            string regresar;

            do
            {
                Console.Clear();
                Console.Write($"Introduce el # de pacientes a evaluar: ");
                n = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    Console.Write(String.Format("\nIngrese el peso en kg del paciente {0}: ", i));
                    peso = Convert.ToDouble(Console.ReadLine());

                    Console.Write(String.Format("\nIngrese la estatura en m del paciente {0}: ", i));
                    estatura = Convert.ToDouble(Console.ReadLine());

                    imc = peso / Math.Pow(estatura, 2);

                    switch (imc)
                    {
                        case double IMC when (IMC < 18.5):
                            Console.WriteLine(String.Format("El paciente {0} tiene peso insuficiente", i));
                            break;

                        case double IMC when (IMC >= 18.5 && IMC < 25):
                            Console.WriteLine(String.Format("El paciente {0} tiene peso saludable", i));
                            break;

                        case double IMC when (IMC >= 25 && IMC < 30):
                            Console.WriteLine(String.Format("El paciente {0} tiene sobrepeso", i));
                            break;

                        case double IMC when (IMC >= 30):
                            Console.WriteLine(String.Format("El paciente {0} tiene obesidad", i));
                            break;
                    }
                }

                Console.Write("\n¿Deseas calcular el IMC de nuevos pacientes? Digite: si/no - ");
                regresar = Console.ReadLine().ToLower();

            } while (regresar == "si" || regresar == "sí");
        }
    }
}
