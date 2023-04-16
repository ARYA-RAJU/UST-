using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddoreven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter the number :");
            x=int.Parse(Console.ReadLine());
            if(x%2==0 )
            {
                Console.WriteLine("number is even");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("number is odd");
                Console.ReadKey();
            }
        }
    }
}
