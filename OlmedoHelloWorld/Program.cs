using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlmedoHelloWorld
{
    //Class: Program
    //Author: Dennis Olmedo
    //Purpose: Try out C# with basic variable assignment and display on console
    //Restrictions: None
    static class Program
    {
        static void Main(string[] args)
        {
            //declare variables as needed
            string testString = "Hello World!";
            int testNum = 10;

            //Here I print out both of my variables
            Console.WriteLine(testString + " My name is Dennis Olmedo");
            Console.WriteLine(testNum);

            //This loop subtracts 1 from testNum until it reaches 0
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(testNum);
                testNum -= 1;
                
            }
        }
    }
}
