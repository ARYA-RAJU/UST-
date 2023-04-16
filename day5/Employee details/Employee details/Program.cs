using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_details
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Employee a = null;
            do
            {
                Console.WriteLine("******Employee Detailes********");
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Display");
                Console.WriteLine("3.search");
                Console.WriteLine("0.exit");
                Console.WriteLine("Enter your choice :");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter the employee Id :");
                        int Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the employee name :");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Enter the salary :");
                        decimal Salary = decimal.Parse(Console.ReadLine());
                        a = new Employee();
                        a.Add(Id, Name, Salary);
                        break;
                    case 2: 
                        if(a!=null)
                        {
                            a.DisplayInfo();
                        }
                        else
                        {
                            Console.WriteLine("Add employee details");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the employee Id :");
                        int id1=int.Parse(Console.ReadLine());
                        a.Search(id1);
                        Console.WriteLine("Employee details");
                        a.DisplayInfo();
                        Console.WriteLine();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("wrong choice");
                        break;

                }
            }
            while (ch != 0);
        }
    }
        
}
