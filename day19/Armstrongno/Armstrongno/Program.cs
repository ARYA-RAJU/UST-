using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Armstrongno
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter thenumber :");
            int n=int.Parse(Console.ReadLine());
            int temp = n;
            int s=armstrongno(n);
            if(temp==s)
            {
                Console.WriteLine("number is armstrong");
            }
            else
            {
                Console.WriteLine("number is not armstrong");
            }

        }

        public static int  armstrongno(int n)
        {
            
            int rem,arm=0;
            
            while(n>0)
            {
                rem = n % 10;
                arm = arm + (rem * rem * rem);
                n = n / 10;
            }
            return arm;
        }
       
    }
}
