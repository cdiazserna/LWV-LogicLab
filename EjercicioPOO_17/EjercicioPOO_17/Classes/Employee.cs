using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPOO_17.Classes
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } //Notación Pascal
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HiringDate { get; set; }
        public bool IsActive { get; set; }

        //Notación Pascal Case: se usa para nombrar métodos, clases y propiedades. ejemplo: LastName
        //Notación Camel Case: se usa en variables, ejemplo: lastName

        public virtual decimal GetValueToPay()
        {
            return 0;
        }

        public virtual string ShowEmployee()
        {
            var employeeInfo = $"Información Empleado \n" +
                $"Id: {Id} \n" +
                $"Nombres: {FirstName} \n" +
                $"Apellidos: {LastName} \n" +
                $"Fecha Nacimiento: {BirthDate} \n" +
                $"Fecha Contratación: {HiringDate} \n" +
                $"Estado: {IsActive} \n";

            return employeeInfo;
        }
    }
}
