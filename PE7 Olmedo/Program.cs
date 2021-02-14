using System;
using System.IO;

namespace PE7_Olmedo
{
    //Author: Dennis Olmedo
    //Class: Program
    //Purpose: Mad Libs game
    //Restrictions: None
    static class Program
    {
        //Method: Main
        //Purpose
        //Restrictions: None
        static void Main(string[] args)
        {
            int numLibs = 0;
            int cntr = 0;
            int nChoice = 0;
            string name;

            StreamReader input;

            //open the file to count the amount of Mad Libs in it
            input = new StreamReader("MadLibsTemplate.txt");

            string line = null;

            while ((line = input.ReadLine()) != null)
            {
                ++numLibs;
            }

            // close it
            input.Close();

            //make strings for the amount of Mad Libs on file
            string[] madLibs = new string[numLibs];
            
            //read the Mad Libs into array of strings
            input = new StreamReader("MadLibsTemplate.txt");

            line = null;
            while ((line = input.ReadLine()) != null)
            {
                madLibs[cntr] = line;

                madLibs[cntr] = madLibs[cntr].Replace("\\n", "\n");

                ++cntr;
            }
            
            input.Close();

            //prompt the user for their name and which Mad Lib they want to play    
            try
            {
                Console.WriteLine("Please enter your name");
                name = Console.ReadLine();
                Console.WriteLine("Please select a Mad Lib: 0-5");
                nChoice = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception)
            {

                throw;
            }

            string resultString = null;

            // split the Mad Lib into words
            string[] words = madLibs[nChoice].Split(' ');

            //go through each word in the selected Mad Lib and pull out the input prompts
            foreach ( string word in words)
            {
                if (word == "\n")
                {
                    resultString += "\n";
                    Console.WriteLine("please");
                }
                else if(word == "{")
                {
                    Console.WriteLine("Prompt here");
                }
                Console.WriteLine(word);
                //Console.WriteLine(resultString);
            }            

        }

    }
}
