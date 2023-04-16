using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace length
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            int length = 0;
            foreach(char chr in str) 
            {

                length += 1;
            }
            Console.WriteLine("length of string is:" + length);
            Console.ReadKey();

        }
    }
}
