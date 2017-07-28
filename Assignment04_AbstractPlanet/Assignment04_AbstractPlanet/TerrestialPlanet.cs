using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Name: Akshay Patel
 * 300918514
 * Comp 123 Assignment 04 ABSTRACT PLANET
 * Version 2.2 - Added Interface Method.
 */
namespace Assignment04_AbstractPlanet
{
    /// <summary>
    /// This is a public TerrestialPlanet subclass.
    /// </summary>
    public class TerrestialPlanet : Planet
    {
        // Private Instance Variables
        private bool _oxygen;

        // Constructor =========================================
        ///<summary>
        ///This is the constructor of TerrestialPlanet subclass.
        /// It takes 5 arguments - name(string), diameter(double), mass(double), oxygen(bool), moonCount(int).
        /// From which 3  arguments name, diameter and mass are derived from Planet class.
        /// </summary>
        public TerrestialPlanet(string name, double diameter, double mass, bool oxygen, int moonCount) : base (name, diameter, mass)
        {
            _oxygen = oxygen;
        } 
        // Interface Method
        public bool HasMoons()
        {
            if(_moon)
        }
    }
}
