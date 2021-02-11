using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;


namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>
    // Class: Class1
    // Author: Dennis Olmedo
    // Purpose: Bug squashing exercise
    // Restrictions: None


    static class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;

            double input1 = -1;
            double input2 = -1;
            bool bValid = false;

            try
            {
                string sResponse = Console.ReadLine();
                Int32 nResponse = int.Parse(sResponse);
                bValid = true;
            }
            catch
            {
                Console.WriteLine("Please enter an integer.");
                bValid = false;
            }
            finally
            {
                Console.WriteLine("This line will always be output!");
            }

            /*do
            {
                Console.Write("Please enter a start and end value:");
                bValid = double.TryParse(Console.ReadLine(), out input1);

                Console.WriteLine("Please enter an end value");
                bValid = double.TryParse(Console.ReadLine(), out input2);  
            } while (!bValid);*/

            Console.WriteLine();

            if (input1 >= 0) {

                for (imagCoord = input1; imagCoord >= -(input2); imagCoord -= 0.05)
                {
                    for (realCoord = -.6; realCoord <= 1.77; realCoord += 0.03)
                    {
                        iterations = 0;
                        realTemp = realCoord;
                        imagTemp = imagCoord;
                        arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                        while ((arg < 4) && (iterations < 40))
                        {
                            realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                               - realCoord;
                            imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                            realTemp = realTemp2;
                            arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                            iterations += 1;
                        }
                        switch (iterations % 4)
                        {
                            case 0:
                                Console.Write(".");
                                break;
                            case 1:
                                Console.Write("o");
                                break;
                            case 2:
                                Console.Write("O");
                                break;
                            case 3:
                                Console.Write("@");
                                break;
                        }
                    }
                    Console.Write("\n");
                }
            }

        }
    }
}

