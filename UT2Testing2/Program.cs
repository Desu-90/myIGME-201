using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace UT2Testing2
{
    static class Program
    {

        //struct Friend
        //{
        //    public string name;
        //    public string greeting;
        //    public DateTime birthdate;
        //    public string address;
        //}

        public class Friend
        {
            public string name;
            public string greeting;
            public DateTime birthdate;
            public string address;
        }

        static void Main(string[] args)
        {
            Friend friend = new Friend();
            friend.name = "Charlie Sheen";
            friend.greeting = "Dear Charlie";
            friend.birthdate = DateTime.Parse("1967-12-25");
            friend.address = "123 any Street, NY NY 12202";

            Friend enemy = new Friend();

            enemy.greeting = "Sorry Charlie";
            enemy.address = "Return to sender. Address unknown";

            Console.WriteLine($"friend.greeting => enemy.greeting: {friend.greeting} => {enemy.greeting}");
            Console.WriteLine($"friend.address => enemy.address: {friend.address} => {enemy.address}");
        }
    }


    }

