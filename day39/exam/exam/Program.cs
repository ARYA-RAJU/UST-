using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] str = { 1, 2, 2, 4 };
            int str1 = 0;
            for(int i=0;i<=str.Length-1;i++)
            { 
                str1 = str[i]+str[i+1]; //str1=couplesum
                if (str1%2==0)
                {
                    str1 = str1 + 10;
                }

            }
            Console.WriteLine("couplesum is " + str1);
            int str2 = 0;
            for(int i=0;i<= str.Length-2;i++)
            {
                str2 = str[i]+str[i + 1] + str[i + 2];
                if(str2%2==0)
                {
                    str2 = str2 + 5;
                }
            
            }
            Console.WriteLine("triplet sum is "+str2);
        }
    }
}
