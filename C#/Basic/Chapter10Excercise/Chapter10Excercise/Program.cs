using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Chapter10Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime dateTime = new DateTime(2021,4,3,new GregorianCalendar());
            DateTime dateTime = DateTime.Now;
            Calendar myCal = CultureInfo.InvariantCulture.Calendar;

            Console.WriteLine("Before adding value in datTime");
            DisplayData(myCal, dateTime);
            dateTime = myCal.AddYears(dateTime, 5);
            dateTime = myCal.AddMonths(dateTime, 5);
            dateTime = myCal.AddWeeks(dateTime, 5);
            dateTime = myCal.AddDays(dateTime, 5);
            dateTime = myCal.AddHours(dateTime, 5);
            dateTime = myCal.AddMinutes(dateTime, 5);
            dateTime = myCal.AddSeconds(dateTime, 5);
            dateTime = myCal.AddMilliseconds(dateTime, 5);
            Console.WriteLine();
            Console.WriteLine("After adding 5 value in each of this");
            DisplayData(myCal, dateTime);
            Console.ReadLine();
        }

        static void DisplayData(Calendar myCal,DateTime dateTime) {
            Console.WriteLine("   Era:          {0}", myCal.GetEra(dateTime));
            Console.WriteLine("   Year:         {0}", myCal.GetYear(dateTime));
            Console.WriteLine("   Month:        {0}", myCal.GetMonth(dateTime));
            Console.WriteLine("   DayOfYear:    {0}", myCal.GetDayOfYear(dateTime));
            Console.WriteLine("   DayOfMonth:   {0}", myCal.GetDayOfMonth(dateTime));
            Console.WriteLine("   DayOfWeek:    {0}", myCal.GetDayOfWeek(dateTime));
            Console.WriteLine("   Hour:         {0}", myCal.GetHour(dateTime));
            Console.WriteLine("   Minute:       {0}", myCal.GetMinute(dateTime));
            Console.WriteLine("   Second:       {0}", myCal.GetSecond(dateTime));
            Console.WriteLine("   Milliseconds: {0}", myCal.GetMilliseconds(dateTime));
            Console.WriteLine();
        }
    }
}
