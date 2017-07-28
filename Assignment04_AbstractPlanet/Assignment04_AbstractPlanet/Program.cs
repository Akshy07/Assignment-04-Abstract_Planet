using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Name: Akshay Patel
 * 300918514
 * Comp 123 Assignment 04 ABSTRACT PLANET
 * Version 4.0 - This is a driver .
 * version 4.1 - Added to the driver class
 */

namespace Assignment04_AbstractPlanet
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Earth", 115364, 1296354, "Solid", 2, 1);
            Console.WriteLine(giantPlanet.ToString());
            Console.WriteLine();
            Console.WriteLine();
            TerrestialPlanet terrestialPlanet = new TerrestialPlanet("Mars", 105236, 1000036, true, 2);
            Console.WriteLine();
            Console.WriteLine();
            WaitForAnyKey();
        }
        public static void WaitForAnyKey()
        {
            Console.ReadKey();
        }
    }
}
