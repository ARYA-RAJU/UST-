//Write a program in C# Sharp to read a string through the keyboard
//and sort it using bubble sort
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubblesort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of strings :");
            int n = int.Parse(Console.ReadLine());
            string[] str = new string[n];
            Console.WriteLine("Input {0} strings below :\n", n);
            for (int i = 0; i < n; i++)
            {
                str[i] = Console.ReadLine();
            }
            Sort(str);
            Console.ReadKey();

        }
        static void Sort(string[] str)
        {
            for (int i = 0; i <= str.Length-2 ; i++)
            {
                for (int j = 0; j <= str.Length - 2; j++)
                {
                    if (str[i].CompareTo(str[i + 1]) > 0)
                    {
                        string temp = str[i + 1];
                        str[i + 1] = str[i];
                        str[i] = temp;

                    }
                }
                
            }
            Console.WriteLine("Sorted string is");
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);

            }

        }

    }
}
  
