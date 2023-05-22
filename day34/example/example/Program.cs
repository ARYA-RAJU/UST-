using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            string str2;
            Console.WriteLine("Enter the string1:");
            str1 = Console.ReadLine();
            Console.WriteLine("enter the string2:");
            str2 = Console.ReadLine();
            int l1 = str1.Length;
            int l2 = str2.Length;
            int flag = 0;
            if (l1 == l2)
            {
                for (int i = 0; i < l1; i++)
                {
                    if (str1[i] == str2[i])
                    {
                        flag = 1;
                    }
                }

            }
            if (flag == 1)
            {
                Console.WriteLine("same");
            }
            else
            {
                Console.WriteLine("differnt");
            }
        }


    }
}
 