using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decimaltobinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            string result;
            Console.WriteLine("Enter the number :");
            answer=Console.ReadLine();

            int num=Convert.ToInt32(answer);
            result = "";
            while(num>1)
            {
                int reminder = num % 2;
                result = Convert.ToString(reminder) + result;
                num/= 2;
            }
            result=Convert.ToString(num) + result;
            Console.WriteLine("Binary {0}" ,result);
            Console.ReadLine();
        }
    }
}
