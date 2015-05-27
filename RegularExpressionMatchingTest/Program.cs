using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionMatchingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //defining some word for test 
            string[] testWord = { "14522-asAdE", "getAE-12343", "ERdee-qw e",};
            string testword1 = "local machine";

            Regex regex1 = new Regex(@"\d-\w$");
            Regex regex2 = new Regex(@"\w$/s\w");

            foreach (var item in testWord)
            {
                Console.WriteLine("{0} {1} a valid match", item, regex1.IsMatch(item)? "is" : "is not");
            }

            Console.WriteLine("{0} {1} a valid match", testword1, regex2.IsMatch(testword1) ? "is" : "is not");
        }
    }
}
