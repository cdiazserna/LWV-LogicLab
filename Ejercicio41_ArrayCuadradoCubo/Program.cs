using System;

namespace Ejercicio41_ArrayCuadradoCubo
{
    public class Program
    {
        //Realizar un programa que declare un array con 10 enteros, a continuación, lo inicialice con valores aleatorios (del 1 al 10) y posteriormente muestre en pantalla cada elemento del vector junto con su cuadrado y su cubo. 

        static void Main(string[] args)
        {
            //Variables globales
            double[] nums = new double[10];
            Random random = new Random(); //Random class

            //Método: InitArray();
            InitArray(nums, random); //Aquí paso PARÁMETROS (las mismas variables o pueden ser objetos)

            CalculateSquareCube(nums);
        }

        //Paso el argumento con su respectivo TIPO DE DATO
        private static void InitArray(double[] nums, Random random) 
        {
            //Generamos el Random e inicializamos el array
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(1, 11); //No pongo 10 porque el límite superior no incluye el valor.
            }
        }

        private static void CalculateSquareCube(double[] nums)
        {
            double[] squares = new double[nums.Length];
            double[] cubes = new double[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                squares[i] = Math.Pow(nums[i], 2);
                cubes[i] = Math.Pow(nums[i], 3);    
            }

            ShowArray(nums, squares, cubes);
        }

        private static void ShowArray(double[] nums, double[] sqr, double[] cube)
        {
            Console.WriteLine("Número Cuadrado Cubo");
            Console.WriteLine("--------------------");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{nums[i], 6} {sqr[i], 6} {cube[i], 6}");
            }
        }

        //TAREA: Intenten por sus propios medios que esa app regrese al Main y me genere 10 nuevos números aleatorios!
    }
}
