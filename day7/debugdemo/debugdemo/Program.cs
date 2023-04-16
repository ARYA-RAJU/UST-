using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first no: ");
            int i=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second no: ");
            int j = int.Parse(Console.ReadLine());
            foo(i, j);
            Console.WriteLine("debugging over");

        }
        public static void foo(int x,int y)
        {
            int t = 100;
            for(int i=x;i<=y;i++)
            {
                Console.WriteLine("India");
                t = t + 34;
                
                
                
            }
        }
    }
}
