﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vehicles;

namespace Traffic
{
    class Program
    {
        static void Main(string[] args)
        {
            AddPassenger(new Compact());
            AddPassenger(new SUV());
            AddPassenger(new Pickup());
            AddPassenger(new PassengerTrain());
        }

        static void AddPassenger(IPassengerCarrier Vehicle)
        {
            Console.WriteLine(Vehicle.ToString());

        }
    }
}
