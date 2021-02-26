using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Questions_UT1
{
    class Program
    {
        static void Main(string[] args)
        {

            string sQuestion = "";
            int nQuestion = 0;
            bool bValid = false;
            string sResponse = "";

        start:
            Console.WriteLine();
            do
            {
                Console.WriteLine("Choose your question (1-3)");
                sQuestion = Console.ReadLine();

                try
                {
                    nQuestion = int.Parse(sQuestion);
                    if(nQuestion > 0)
                    {
                        if(nQuestion < 4)
                        {
                            bValid = true;
                        }
                    }
            
                }
                catch
                {
                    Console.WriteLine();
                    bValid = false;
                }

            } while (!bValid);

            Console.WriteLine();

            do
            {
                sResponse = Console.ReadLine();
                switch (nQuestion)
                {
                    case 1:
                        Console.WriteLine("What is your favorite color");
                        break;
                    case 2:
                        Console.WriteLine("What is the answer to life, the universe and everything");
                        break;
                    case 3:
                        Console.WriteLine("What is the airspeed velocity of an unladen swallow");
                        break;

                }
                try
                {
                    sResponse = "black";
                    bValid = true;
                }
                catch
                {
                    Console.WriteLine();
                    bValid = false;
                }
            } while (true);
            


        }
    }
}
