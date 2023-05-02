using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList s = new SortedList();
            s.Add("Maharashtra     ", "Mumbai");
            s.Add("Karnataka       ", "Banglore");
            s.Add("Andhra Pradesh  ", "Hydrabad");
            s.Add("Tamilnadu       ", "Chennai");
            s.Add("Bihar           ", "Patna");
            s.Add("Rajasthan       ", "Jaipur");
            Console.WriteLine("Elements in the list");
            foreach (var item in s.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in s.Values)
            {
                Console.WriteLine(item);
            }

        }
    }
}
