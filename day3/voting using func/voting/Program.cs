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
            Console.WriteLine("Enter the age :");
            age=int.Parse(Console.ReadLine());
            int result = Eligibility(age);
            if(result==1)
            {
                Console.WriteLine("Eligible to vote");
                
            }
            else
            {
                Console.WriteLine("Not eligible to vote");
            }
            Console.ReadKey();  
        }
        static int  Eligibility(int age)
        {
            
            if (age>= 18)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }

}
