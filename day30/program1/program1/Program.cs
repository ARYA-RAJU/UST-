using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    //enter 5 integers in an array and print in reverse  order
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 integers:");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Display(arr);
        }
        public static void Display(int[] arr)
        {
            Console.WriteLine("integers in reverse order");
            for (int i = 4; i >= 0; i--)
            {
              Console.WriteLine(arr[i]);
            }
        }
    }

}
