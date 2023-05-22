using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    class Employee
    {
        public int Id;
        public string Name;
        public double Salary;
        public Employee() 
        { 
        
        }
        public Employee(int  id,string name,double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;    
        }

        //copy constructor
        public Employee(Employee emp)
        {
            Id=emp.Id;
            Name = emp.Name;
            Salary = emp.Salary;
        }
        public void Display()
        {
            Console.WriteLine("Employee id :"+Id);
            Console.WriteLine("Employee Name :"+Name);
            Console.WriteLine("Employee Salary :"+Salary);
        }
    }
}
