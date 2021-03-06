﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaveColNum
{
    //Class: Program
    //Author: Dennis Olmedo
    //Purpose: Console Read/Write and Exception-handling exercise
    //Restriction: None
    static class Program
    {
        //Method: Main
        //Purpose: Prompt the user for their favorite color and number
        //         Output their favorite color (in limited text colors) their fav number of times
        //Restricions: None
        
        static void Main(string[] args)
        {
            // declare our needed variables
            string color = null;
            int favNum = 0;
            int i;
            bool bValid = false;
            //prompt the user for fav color
            Console.Write("Enter your favorite color:\t");

            //read color from the keyboard
            color = Console.ReadLine();

            //prompt the user for fav number
            Console.Write("Enter your favorite number:\t");

            do
            {


                try
                {
                    // read number from the keyboard
                    favNum = Convert.ToInt32(Console.ReadLine());
                    bValid = true;
                }
                catch
                {
                    Console.WriteLine("Please enter an integer");
                }
            } while (!bValid);

            //change the text color to their favorite color
            switch (color.ToLower())                               
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

            }

            // loop to output their fav number of times
            for (i = 0; i < favNum; ++i)
            {
                Console.WriteLine("Your favorite color is " + color);
            }
        }
    }
}
