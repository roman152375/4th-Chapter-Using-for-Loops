using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
        ProgramStart:
            Console.WriteLine("Enter an integer:");
            int myInt = Convert.ToInt32(Console.ReadLine());
            bool isLessThan10 = myInt < 10;
            bool isBetween0and5 = (0 <= myInt) && (myInt <= 5);
            if (isBetween0and5 == false)
                goto ProgramStart;

            Console.WriteLine("Integer less than 10? {0}", isLessThan10);
            Console.WriteLine("Integer between 0 and 5? {0}", isBetween0and5);
            Console.WriteLine("Exactly one of the above is true? {0}", isLessThan10 ^ isBetween0and5);

            string resultString = (isLessThan10 == true) ? "Less than 10" : "Greater than or equal to 10";

            if (isLessThan10 == true)
            {
                resultString = "Number is less than 10";
            }
            else
            {
                resultString = "Number is greater than or equal to 10";
            }

            Console.ReadKey();
        }
    }
}
