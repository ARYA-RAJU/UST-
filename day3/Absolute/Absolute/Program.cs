//Program to find absolute difference
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absolute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number :");
            n=int.Parse(Console.ReadLine());
            int result = Absolutediff(n);
            Console.WriteLine("Absolute difference is :" + result);
            Console.ReadLine();
        }
        static int Absolutediff(int n)
        {
            if (n > 51) //Check if  n is greater than 51
            {
                int res = (n - 51) * 3;
                return res;
                
            }
            else
            {
                int res1 = n - 51;
                return res1;
                
            }
         }
    }
}
