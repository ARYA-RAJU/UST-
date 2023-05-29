using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge1
{
    
    class Inner
    {

        public class Private
        {
            public bool Power(int n)
            {
                if(n==0)
                
                    return false;
                
                while(n!=1)
                {
                    if (n % 2 != 0)
                    {
                        return false;
                    }
                     n = n / 2;
                    
                    
                }
                return true;
            }
        }
        class Solution
        {
            static void Main(string[] args)
            {
                Inner.Private innerprivate = new Inner.Private();
                Console.WriteLine("Enter the number:");
                int n = int.Parse(Console.ReadLine());
                if (innerprivate.Power(n))
                {
                    Console.WriteLine(n + " is power of 2");
                }
                else
                {
                    Console.WriteLine(n + " is not power of 2");
                }
            }
        }
    }
}
