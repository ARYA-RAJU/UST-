using System;


//calculate area of circle
namespace areaofcircle
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            double r=0.0,area;
            Console.WriteLine("Enter the radius:");
            r = double.Parse(Console.ReadLine());

            area = CalcArea(r);
            Console.WriteLine("Area of circle having radius {0} is {1}", r, area);
            Console.ReadLine();
            
        }
        static double CalcArea(double rr)
        {
            double area = 0.0;
            area = 3.14 * rr * rr;
            return area;
        }
    }
}
