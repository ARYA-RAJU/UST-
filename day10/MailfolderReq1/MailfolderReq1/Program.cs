using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailfolderReq1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mail> li = new List<Mail>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter mail{0} detail", i + 1);
                string[] s = Console.ReadLine().Split(',');
                Mail m1 = new Mail(long.Parse(s[0]), s[1], s[2], s[3], s[4], DateTime.ParseExact(s[5], "dd-MM-yyyy", null), double.Parse(s[6]));
                li.Add(m1);
            }
            Console.WriteLine();
            int j = 1;
            foreach (var item in li)
            {
                Console.WriteLine("Mail {0} :", j);
                Console.WriteLine(item.ToString());
                j++;
            }
            if (li[0].Equals(li[1]))
            {
                Console.WriteLine("mail is same");
            }
            else
            {
                Console.WriteLine("mail is different");
            }
        }

    }
}

