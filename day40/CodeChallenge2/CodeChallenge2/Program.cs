using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of sente1nces:");
            int n=int.Parse(Console.ReadLine());
            string[] str = new string[n];
            for(int i=0;i<n;i++)
            {
                str[i] = Console.ReadLine();
            }
            foreach(string str1 in str)
            {
                string result = RemoveDuplicateWords(str1);
                Console.WriteLine(result);
            }
        }
        static string RemoveDuplicateWords(string sentence)
        {
            string pattern = @"\b(\w+)\b\s+(?=.*\b\1\b)";
            string rep = "";
            Regex regex = new Regex(pattern);
            string result=regex.Replace(sentence, rep);
            return result;
        }
    }
}
