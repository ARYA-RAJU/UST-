using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure fig = new Square();
            fig.Dimension = 10;
            Console.WriteLine("Area of square :" +fig.Area());
            Console.WriteLine("Perimeter of square :" +fig.Perimeter());
            Figure fig1 = new Circle();
            fig1.Dimension = 10;
            Console.WriteLine("Area of Circle :" + fig1.Area());
            Console.WriteLine("Perimeter of Circle :" + fig1.Perimeter());
            Console.ReadKey();
        }
    }
}
