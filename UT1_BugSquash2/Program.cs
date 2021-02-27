using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT1_BugSquash2
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            //int nY  compile time error
            int nY;
            int nAnswer;

            //Console.WriteLine(This program calculates x ^ y.); Compile-time error, missing double quotes
            Console.WriteLine("This program calculates x ^ y");

            do
            {
                Console.Write("Enter a whole number for x: ");
                //Console.ReadLine(); logic error because that input is not being saved anywhere
                sNumber = Console.ReadLine();
            } //while (!int.TryParse(sNumber, out nX)); Compile time error because sNumber has nothing assigned to it
            while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            } //while (int.TryParse(sNumber, out nX)); logic error, nothing is being stored into nY causing it to have an error at line 38
            //while (int.TryParse(sNumber, out nY)); runtime error, this line causes an infinite loop
            while (!int.TryParse(sNumber, out nY));

            // compute the factorial of the number using a recursive function
            //nAnswer = Power(nX, nY); compile time error if the changes at line 35 are not done
            nAnswer = Power(nX, nY);
            //Console.WriteLine("{nX}^{nY} = {nAnswer}"); logic error, this does not display what is desired
            Console.WriteLine("{0} ^ {1} = {2}", nX, nY, nAnswer);
        }


        static int Power(int nBase, int nExponent)
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                //returnVal = 0; logic error, getting the wrong number
                returnVal = 1;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                //nextVal = Power(nBase, nExponent + 1); logic error, this creates an infinite loop
                nextVal = Power(nBase, nExponent - 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            //returnVal; compile-time error, nothing is being returned so the function would not work
            return returnVal;

        }
    }
}
