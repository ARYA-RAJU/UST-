//Write a program in C# Sharp to search the position of a substring within a string
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            string substr;
            Console.WriteLine("Enter the string :");
            str = Console.ReadLine();
            Console.WriteLine("Enter the substring to be searched:");
            substr = Console.ReadLine();
            int index=str.IndexOf(substr);
            if(index<0) 
            {
                Console.WriteLine("substring not found");
            }
            else
            {
                Console.WriteLine("Found '{0}' in '{1}' at position {2}",
                        substr, str, index);
                Console.ReadKey();
            }
            
        }
    }
}
