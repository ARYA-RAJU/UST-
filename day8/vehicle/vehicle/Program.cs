using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{
    class Vehicle  
    {
        public string brand = "Ford";  
        public void honk()             
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle  
    {
        public string modelName = "Mustang";  
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Car myCar = new Car();

            
            myCar.honk();

            Console.WriteLine(myCar.brand + " " + myCar.modelName);
            Console.ReadKey();
        }
    }
}
