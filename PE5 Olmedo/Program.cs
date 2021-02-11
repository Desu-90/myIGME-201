using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE5_Olmedo
{    // Class: Program
    // Author: Dennis Olmedo
    // Purpose: Parsing and formatting practice exercise
    // Restrictions: None
    static class Program
    {
        //Method: Main
        //Purpose: Parsing and Formatting practice
        //Restrictions: None
        static void Main(string[] args)
        {
            //Declaring our variables
            Random rand = new Random();

            // generate a random number between 0 inclusive and 101 exclusive
            int randomNumber = rand.Next(0, 101);

            int input;
            Console.WriteLine(randomNumber);
            int i;
            Console.WriteLine("Please enter a number between 1 and 100");

            for (i = 1; i <= 8; i++)
            {
                //Prompt user for input
                Console.Write("Turn #" + (i) + ": ");
                input = Convert.ToInt32(Console.ReadLine());
                //If the input is lower than the answer, tell the user it is
                if (input < randomNumber)
                {
                    Console.WriteLine("Go a little higher!");
                }
                //If the input is the right answer, let the user know and break out of loop
                else if (input == randomNumber)
                {                  
                        Console.WriteLine("Wohoo you got it right! Took ya " + (i) + " turns");
                        break;                    
                    
                }          
                //If the input is greater than the answer, let the user know it is
                else
                {
                    Console.WriteLine("Woah there! Go down more");
                }
                
            }
            Console.WriteLine("Amount of guesses: " + i);

        }
    }
}
