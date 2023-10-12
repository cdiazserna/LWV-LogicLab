using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EjercicioPOO_17.Classes
{
    public class SalaryEmployee : Employee //Aquí ya estoy heredando de mi papá Employee
    {
        public decimal Salary { get; set; }

        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ShowEmployee() 
        {
            var salaryEmployeeInfo = $"{base.ShowEmployee()}" + 
                $"Salario: {GetValueToPay()}";

            return salaryEmployeeInfo;
        }
    }
}
