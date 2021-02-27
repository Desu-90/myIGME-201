using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _3Questions_UT1
{
    class Program
    {
        static bool bTimeOut = false;
        static Timer timeOutTimer;
        static void Main(string[] args)
        {

            string sQuestion = "";
            int nQuestion = 0;
            bool bValid = false;
            string sResponse = "";
            int nResponse = 0;

        start:
            Console.WriteLine();
            do
            {
                Console.Write("Choose your question (1-3)");
                sQuestion = Console.ReadLine();

                try
                {
                    nQuestion = int.Parse(sQuestion);
                    if (nQuestion > 0)
                    {
                        if (nQuestion < 4)
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

            //declare a variable of delegate type
            ElapsedEventHandler elapsedEventHandler;

            //point to the TimesUp method
            elapsedEventHandler = new ElapsedEventHandler(TimesUp);

            timeOutTimer = new Timer(5000);
            timeOutTimer.Elapsed += elapsedEventHandler;
            timeOutTimer.Start();
            do
            {
                sResponse = Console.ReadLine();
                switch (nQuestion)
                {
                    case 1:
                        Console.WriteLine("What is your favorite color?");
                        break;
                    case 2:
                        Console.WriteLine("What is the answer to life, the universe and everything?");
                        break;
                    case 3:
                        Console.WriteLine("What is the airspeed velocity of an unladen swallow?");
                        break;

                }
                timeOutTimer.Stop();
                try
                {
                    nResponse = int.Parse(sResponse);
                    bValid = true;
                }
                catch
                {
                    Console.WriteLine();
                    bValid = false;
                }
            } while (!bValid);




        }
        static void TimesUp(object source, ElapsedEventArgs e)
        {
            Console.WriteLine();
            Console.WriteLine("Time's up!");

            timeOutTimer.Stop();
        }
    }
}