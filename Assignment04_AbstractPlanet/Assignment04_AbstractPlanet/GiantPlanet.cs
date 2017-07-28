using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Name: Akshay Patel
 * 300918514
 * Comp 123 Assignment 04 ABSTRACT PLANET
 * Version 1.3 - Derived the interfaces and implemented. 
 */

namespace Assignment04_AbstractPlanet
{
    /// <summary>
    /// This is a public GiantPlanet subclass.
    /// </summary>
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        // Private Instance Variables
        private string _type;
        private int _moonCount;
        private int _ringCount;

        //Constructor =========================================
        ///<summary>
        ///This is the main constructor of GiantPlanet class
        ///This constructor takes 6 arguments - name(string), diameter(double), mass(double), type(string), moonCount(int), ringCount(int).
        ///From which 3 arguments - name, diameter and mass are from Planet(base) class.
        /// </summary>
        public GiantPlanet(string name, double diameter, double mass, string type, int moonCount, int ringCount) : base(name, diameter, mass)
        {
            _type = type;
            _moonCount = moonCount;
            _ringCount = ringCount;
        }

        // Interface Method
        //HasMoons
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //HasRings
        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else 
            {
                return false;
            }

        }
    }
}
