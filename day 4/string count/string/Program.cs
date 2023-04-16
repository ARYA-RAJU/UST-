//Write a program in C# Sharp to count a total number of alphabets,
//digits and special characters in a string
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x;
            Console.WriteLine("Enter the string :");
            x= Console.ReadLine();
            int i = 0,count=0,count1=0,count2=0;
            int l=x.Length;
            while(i < l) 
            {
                if ((x[i]>='a') && (x[i]<='z') || (x[i]>='A') && (x[i]<='Z'))
                {
                    count++;
                    
                }
                else if ((x[i]>='0') && (x[i]<='9'))
                {
                    count1++;
                }
                else
                {
                    count2++;
                }
                i++;
                
            }
            Console.WriteLine("Number of Alphabets in the string is :" + count);
            Console.WriteLine("Number of Digits in the string is :" + count1);
            Console.WriteLine("Number of Special characters in the string is :" + count2);
            Console.ReadKey();
        }     
    }
}
