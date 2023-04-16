using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumofinteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the first number :");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number :");
            b=int.Parse(Console.ReadLine());
            int result =SumOfIntegers(a, b);    
            Console.WriteLine("Sum is :" +result);
            Console.ReadLine(); 
        }
        static int SumOfIntegers(int a, int b)
        {
            int sum = 0;
            if(a == b)
            {
                sum = (a + b) * 3;
                return sum;
            }
            else
            {
                sum = a + b;
                return sum;
            }

        }
    }
}
