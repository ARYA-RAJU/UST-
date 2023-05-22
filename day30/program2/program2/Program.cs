using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    /*Create a program in C# that serves to search an array of
    integer values.*/
    /*public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of integers");
            int x=int.Parse(Console.ReadLine());
            int[] arr = new int[x];
            Console.WriteLine("Enter {0} integers:",x);
            for (int i = 0; i < x; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            string y;
            do
            {
                Console.WriteLine("Enter the  umber to be searched");
                y = Console.ReadLine();
                if(y != "end")
                {
                    int yToInt = Convert.ToInt32(y);
                    if (Array.BinarySearch(arr, yToInt)>=0)
                    {
                        Console.WriteLine("The number {0} is exist",y);
                    }
                    else
                    {
                        Console.WriteLine("The number {0} is doesnot exist",y);
                    }
                }
            }
            while(y != "end");
        }
    }*/

    //Write a program in C# that asks the user for 10 integers to store them
    //in an array of integers and show only even integers.
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter the 10 integers");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            EvenNo(arr);
        }
        static void EvenNo(int[] arr)
        {
            Console.WriteLine("Even numbers are:");
            for (int i = 0; i < 10; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }

        }
    }
}
