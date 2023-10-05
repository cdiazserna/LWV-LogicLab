using System;

namespace EjercicioPOO_DateClass
{
    public class MyDate
    {
        //Sección de prop
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        //Método ctor
        public MyDate(int day, int month, int year) //day=5, month=8, year=2000
        {
            Day = day;
            Month = month;
            Year = year;
        }

        //Demás métodos
        public string ShowDate()
        {
            return String.Format("{0}/{1}/{2}", Day, Month, Year); //  5/8/2000
        }
    }
}
