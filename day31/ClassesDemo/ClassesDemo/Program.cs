using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1=new Employee(100,"Arya",23000);
            e1.Display();

            Employee e2 = new Employee(e1);
            e2.Display();
        }
    }
}
