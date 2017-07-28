using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Name: Akshay Patel
 * 300918514
 * Comp 123 Assignment 04 ABSTRACT PLANET
 * Version 0.4 - Addaed constructor.
 */

namespace Assignment04_AbstractPlanet
{
    abstract class Planet
    {
        // Private Instance Variables
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        // Public Properties
        /// <summary>
        /// These are readonly properties
        /// </summary>
        
        //Diameter
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }

        //Mass
        public double Mass
        {
            get
            {
                return this._mass;
            }
        }

        //MoonCount
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
        }

        //Name
        public string Name
        {
            get
            {
                return this._name;
            }
        }
        
        /// <summary>
        /// This has values for the set.
        /// </summary>
        //OrbitalPeriod
        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }

        //RingCount
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }

        // RotationPeriod
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        } 

        // Constructors =============================================
        ///<summary>
        ///This is the main constructor of the Abstract Planet class.
        ///It takes three arguments - name(string), diameter(double) and mass(double)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        public Planet(string name, double diameter, double mass)
        {
            _name = name;
            _diameter = diameter;
            _mass = mass;
        }

        // Override Method
    }
}
