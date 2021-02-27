using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT1_Question3
{
    class Program
    {
        //we define the delegate function data type
        delegate string MyReadLine();
        static void Main(string[] args)
        {
            MyReadLine myReadLine;
            myReadLine = new MyReadLine(Console.ReadLine);

            string sString = myReadLine();
        }
    }
}
