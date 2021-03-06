using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12
{
    public class MyClass
    {
        private string myString;

        public virtual string GetString()
        {
            return myString;
        }
    }
    public class MyDerivedClass : MyClass
    {
        public override string GetString()
        {
            return base.GetString() + "(output from derived class)";
        }

        static void Main(string[] args)
        {
            MyDerivedClass output = new MyDerivedClass();
            Console.WriteLine(output);
        }
    }
    
}
