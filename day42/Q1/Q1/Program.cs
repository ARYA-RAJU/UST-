using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
     class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int posCount = 0;
            int negCount = 0;
            int zeroCount = 0;
            foreach (int number in arr)
            {
                if (number > 0)
                    posCount++;
                else if (number < 0)
                    negCount++;
                else
                    zeroCount++;
            }

            double posRatio = (double)posCount / n;
            double negRatio = (double)negCount / n;
            double zeroRatio = (double)zeroCount / n;

            Console.WriteLine(posRatio.ToString("F6"));
            Console.WriteLine(negRatio.ToString("F6"));
            Console.WriteLine(zeroRatio.ToString("F6"));
        }
    }

}
