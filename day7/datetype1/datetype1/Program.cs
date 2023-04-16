using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetype1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // 1.Write a C# Sharp program to get the day of the week for a specified date
            DateTime dt = new DateTime(2023, 02, 18);
            Console.WriteLine("The day of the week for {0:d} is {1}.", dt, dt.DayOfWeek);
            Console.WriteLine();


            //2.Write a C# Sharp program to retrieve the current date
            DateTime dt1 = DateTime.Today;
            Console.WriteLine("General format " + dt1.ToString());
            Console.WriteLine("Display the date in a variety of formats: ");
            Console.WriteLine(dt1.ToString("d"));
            Console.WriteLine(dt1.ToString("D"));
            Console.WriteLine(dt1.ToString("g"));
            Console.WriteLine();


            //3.Write a C# Sharp program to determine the day of the week 40 days after the current date.
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(40);
            Console.WriteLine("Today: {0:dddd}", today);
            Console.WriteLine("40 days from today: {0:dddd}", answer);
            Console.WriteLine();


            //4.Write a program in C# Sharp to get the day and month name of current date
            DateTime date = DateTime.Now;
            Console.WriteLine(" The current Month No. is : {0} ", date.Month);
            Console.WriteLine(" The current Month is : {0}\n", date.ToString("MMMM"));
            Console.WriteLine();

            //5.Write a program in C# Sharp to print the name of the first three letters of month of a year
            //starting form current date.
           
            DateTime now = DateTime.Now;
            Console.WriteLine(" The date of Today : {0}", now.ToString("dd/MM/yyyy"));
            Console.WriteLine(" The twelve months are :");
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(" {0}", now.ToString("MMM"));
                now = now.AddMonths(1);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
