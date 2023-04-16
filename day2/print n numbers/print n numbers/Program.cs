using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_n_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,i;
            Console.WriteLine("enter the number n :");
            n=int.Parse(Console.ReadLine());
            for (i=0;i<=n;i++)
            {
                Console.WriteLine(i);
                
                 
            }
            Console.ReadKey();

            
        }
    }
}
