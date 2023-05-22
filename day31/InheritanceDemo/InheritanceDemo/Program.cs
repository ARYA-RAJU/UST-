using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            B obj=new B();
            obj.Method1();
            obj.Method2();
            obj.Method3();
        }
    }
    class A
    {
        public A() 
        {
            Console.WriteLine("constructor called");
            
        }
        public void Method1()
        {
            Console.WriteLine("method 1");
        }
        public void Method2()
        {
            Console.WriteLine("method 2");
        }

    }
    class B : A
    {
        public B()
        {
            Console.WriteLine("Constructor b called");
        }
        public void Method3()
        {
            Console.WriteLine("method 3");
        }
    }
}
    

