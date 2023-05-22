using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module1
{
    
    

    //Create a C# program that asks the user for 5 real numbers and
    //shows the arithmetic mean of the positive and negative numbers.

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 5 numbers");
            int[] list=new int[5];
            int count1 = 0, count2 = 0;
            int totalPno = 0, totalNno = 0;
            for (int i = 0; i < 5; i++)
            {
                list[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0; i < 5; i++)
            {
                
                if (list[i] > 0)
                {
                    totalPno = totalPno + list[i];
                    count1++;
                }
                else if (list[i] < 0)
                {
                    totalNno =totalNno+ list[i];
                    count2++;
                }
               

            }
            Console.WriteLine("mean of +ve numbers is :"+totalPno/count1);
            Console.WriteLine("mean of _ve numbers is :"+totalNno/count2);

        }
    }
}






