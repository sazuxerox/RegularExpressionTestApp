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
           // defining some word for test 
            string[] testWord = { "14522-asAdE", "getAE-12343", "ERdee-qw e",};
            string testword1 = "local machine"; 
            string testword2 = "A12dfreQ";
            string number = "1234.12";  //define a decimal number as a string


            //defining the vehicle number plate of Bangladesh in a string array
            string[] testWord3 =
            {
                "Dhaka-Metro GA 11-9011", "Chatta-Metro KHA 10-2930",
                "Chittagong Kha 09-1223", "Pabna LA 11-2312"
            }; 

           // Regular Expressiong for sample words
            Regex regex1 = new Regex(@"\d-\w");
            Regex regex2 = new Regex(@"\w");
            Regex regex3 = new Regex(@"[a-zA-Z0-9]");

            //Regular Expression for matching vehicle number plateB
            Regex vehicleRegex = new Regex(@"\w{5,}(-\w{4,})?\s\w{2,}\s\d{2}-\d{4}");

            //Regular expression for a decimal number with regular expression
            Regex decimalRegex = new Regex(@"\d{3,}(\.\d{2})");

            //testing regular expressiong for sample words 
            foreach (var item in testWord)
            {
                Console.WriteLine("{0} {1} a valid match", item, regex1.IsMatch(item) ? "is" : "is not");
            }

            Console.WriteLine("{0} {1} a valid match", testword1, regex2.IsMatch(testword1) ? "is" : "is not");
            Console.WriteLine("{0} {1} a valid match", testword2, regex3.IsMatch(testword2) ? "is" : "is not");

            //testing if the number plate is match with the defined regular expression
            foreach (var item in testWord3)
            {
                Console.WriteLine("{0} {1} a valid match", item, vehicleRegex.IsMatch(item) ? "is" : "is not");
            }

            //testing the regular expression for decimal number 
            Console.WriteLine("{0} {1} a valid match", number, decimalRegex.IsMatch(number) ? "is" : "is not");
        }
    }
}
