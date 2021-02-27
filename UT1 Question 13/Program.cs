using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT1_Question_13
{
    static class Program
    {
        struct employee
        {
            public string sName;
            public double dSalary;
        }
        static void Main(string[] args)
        {
            employee Dennis;
            Dennis.sName = "";
            Dennis.dSalary = 30000;

            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Enter your name");

                Dennis.sName = Console.ReadLine();
                GiveRaise(Dennis.sName, ref Dennis.dSalary);

                if (Dennis.sName.Length > 0)
                {
                    break;
                }
            }
            Console.WriteLine("Congrats {0} you received a raise! Your current salary is {1}", Dennis.sName, Dennis.dSalary);
        }

        static bool GiveRaise(string name, ref double salary)
        {
            if (name == name)
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
