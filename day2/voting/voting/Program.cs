using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("enter the age :");
            age=int.Parse(Console.ReadLine());  
            if(age>=18)
            {
                Console.WriteLine("eligible to vote");
            }
            else
            {
                Console.WriteLine("not eligible to vote");
                Console.ReadLine();
            }
        }
    }
}
