using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        class fruit
        {
            private int _fno;
            public int FNO
            {
                get
                {
                    return _fno;
                }
                set
                {
                    _fno = value;
                }
            }
            private string _name;
            public string Name
            {
                get
                {
                    return _name;
                }
                set
                {
                    if (value != null)
                    {
                        _name = value;
                    }
                    else
                    {
                        Console.WriteLine("invalid fruit name");
                    }
                }
            }
            public fruit()
            {

            }
            public fruit(int fno, string name)
            {
                _fno = fno;
                _name = name;
            }
            public void print()
            {
                Console.WriteLine("Fruit No:" + FNO);
                Console.WriteLine("Fruit Name:" + Name);
                            
            }

        }

        class Orange : fruit
        {
            
            string[] origins = { "Maharashtra", "Himajal", "Thelangana" };
            private string _origin;
            public string Origin
            {
                get
                {
                    return _origin;
                }
                set
                {
                    Array.Sort(origins);
                    if (Array.BinarySearch(origins, value) >= 0)
                    {
                        _origin = value;
                    }
                    else
                    {
                        Console.WriteLine("invalid origin");
                    }
                }
            }

            public Orange()
            {

            }
            public Orange(int fno, string name, string origin) : base(fno, name)
            {
                Origin = origin;
            }
        
            public new void print()
            {
                base.print();

                Console.WriteLine("Origin of Fruit:" + Origin);
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            Orange o1=new Orange(101,"Nagpur Orange","Maharashtra");
            o1.print();
            Orange o2 = new Orange(102, "Solan Keenu", "Himachal");
            o2.print();
        }
        
    }
}
