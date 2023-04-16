using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetimetype
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           Console.WriteLine("currentDateTime: {0}" ,DateTime.Now);
           Console.WriteLine("todaysDate :{0}" ,DateTime.Today);
           DateTime dt1 = new DateTime(2015, 12, 31);
           Console.WriteLine("date : {0}",dt1);

            Console.ReadKey();
        }
    }
}
