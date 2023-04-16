//write a program to enter an amount and findout minimum number of notes required to make that amount
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount :");
            int amount=int.Parse(Console.ReadLine());
            int w=amount / 2000;
            amount = amount % 2000;
            Console.WriteLine("No of 2000 Notes: " +w);
            int x = amount / 500;
            amount=amount % 500;
            Console.WriteLine("No of 500 Notes: " + x);
            int y = amount / 200;
            amount = amount % 200;
            Console.WriteLine("No of 200 Notes: " + y);
            int z = amount / 100;
            amount = amount % 100;
            Console.WriteLine("No of 100 Notes: " + z);
            int m = amount / 50;
            amount = amount % 50;   
            Console.WriteLine("No of 50 Notes: " + m);
            int n = amount / 10;
            amount = amount % 10;
            Console.WriteLine("No of 10 Notes: " + n);
            int o=amount / 5;
            amount = amount / 5;
            Console.WriteLine("No of 5 Notes: " + o);
            int p = amount / 2;
            amount = amount / 2;
            Console.WriteLine("No of 5 Notes: " + p);
            int q = amount / 1;
            amount = amount / 1;
            Console.WriteLine("No of 5 Notes: " + q);
            Console.ReadKey();

        }
    }
}
