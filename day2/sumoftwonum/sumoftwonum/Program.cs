using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace sumoftwonum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b,sum=0;
            Console.WriteLine("Enter first no:");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second no:");
            b=int.Parse(Console.ReadLine());
            sum=a+b;
            Console.WriteLine("sum is {0}",sum);
            Console.ReadKey();
        }
    }
}
