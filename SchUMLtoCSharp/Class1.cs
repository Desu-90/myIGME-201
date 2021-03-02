using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchUMLtoCSharp
{
    //[+A:MyBase|-password:string|+Password:string;+MyAbstractMethod(a:int,b:string):string:a; +MyVirtualMethod(a:string):v]
    public abstract class MyBase
    {
        private string password;
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }

        public abstract string MyAbstractMethod(int a, string b);

        public virtual void MyVirtualMethod(string a)
        {

        }
    }
    //[-MyClass||+MyAbstractMethod(a:int,b:string):string:o]
    //
    //[+IMyBaseInterface|MyMethod(d:double):double]
    public interface IMyBaseInterface
    {
        double MyMethod(double d);
    }
    //[-IMyBaseInterface2|]
    private interface IMyBaseInterface2
    {

    }

    //[-IMyInterface]
    private interface IMyInterface
    {

    }
    //[-S:MyComplexClass||+MyMethod(d:double):double, +MyVirtualMethod(a:string):o]
    //
    //[+A:MyBase] <-.- [-MyClass]
    //
    //[-MyClass] <- [-S:MyComplexClass]
    //
    //[+IMyBaseInterface] ^ [-IMyInterface]
    //
    //[-IMyBaseInterface2] ^ [-IMyInterface]
    //
    //[-IMyInterface] ^ [-S:MyComplexClass]
    public class Class1
    {
    }
}
