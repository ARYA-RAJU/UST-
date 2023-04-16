using System;

namespace Employee_details
{
    class Employee
    {
        public int Id;
        public string Name;
        public decimal Salary;

        public void Add(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Employee Id :" + Id);
            Console.WriteLine("Employee Name :" + Name);
            Console.WriteLine("Salary is :" + Salary);

        }
        public void Search(int id1)
        {
            if(Id == id1)
            { 
                
            }
        }

    }
}