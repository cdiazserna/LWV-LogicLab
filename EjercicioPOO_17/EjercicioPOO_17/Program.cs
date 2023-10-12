using EjercicioPOO_17.Classes;
using System;

namespace EjercicioPOO_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POO - EMPLEADOS\n");
             
            //Creamos la instancia de la clase SalaryEmployee
            SalaryEmployee salaryEmployee = new SalaryEmployee();

            salaryEmployee.Id = Guid.NewGuid();

            Console.Write("Ingrese nombres: ");
            salaryEmployee.FirstName = Console.ReadLine();

            Console.Write("Ingrese apellidos: ");
            salaryEmployee.LastName = Console.ReadLine();

            salaryEmployee.BirthDate = DateTime.Now; //DateTime.Now significa que va a capturar la fecha actual.

            salaryEmployee.HiringDate = DateTime.Now;

            Console.Write("¿Empleado activo?: ");
            salaryEmployee.IsActive = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Ingrese salario del contrato: ");
            salaryEmployee.Salary = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"\n{salaryEmployee.ShowEmployee()}");
        }
    }
}
