using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT1_Question_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string sName;
            double dSalary = 30000;
            bool bValid = false;

            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Enter your name");

                sName = Console.ReadLine();
                GiveRaise(sName, ref dSalary);

                if(sName.Length > 0)
                {
                    break;
                }
            }
            Console.WriteLine("Congrats {0} you received a raise! Your current salary is {1}", sName, dSalary);
        }

        static bool GiveRaise( string name, ref double salary)
        {
            if(name == name)
            {
                salary += 19999;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
