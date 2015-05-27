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

            Regex regex = new Regex(@"\d-\w");

            foreach (var item in testWord)
            {
                Console.WriteLine("{0} {1} a valid match", item, regex.IsMatch(item)? "is" : "is not");
            }
        }
    }
}
