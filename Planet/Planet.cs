﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet
{
   abstract class Planet
    {
        //Private instance varialbes
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double rotationPeriod;

        //Properties
        public string Name
        {
            get{ return this._name; }
        }
        public int MoonCount
        {
            get { return this._moonCount; }
            set { this._moonCount = value; }
        }
        public double Diameter
        {
            get { return this._diameter; }
        }
        public double Mass
        {
            get { return this._mass; }
        }
        public double OrbitalPeriod
        {
            get { return this._orbitalPeriod; }
            set { this._orbitalPeriod = value; }
        }
        
        public int RingCount
        {
            get { return this._ringCount; }
            set { this._ringCount = value; }
        }
        public double RotationPeriod
        {
            get { return this.rotationPeriod; }
            set { this.rotationPeriod = value; }
        }
        //Cunstructor
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.Name, this.Diameter, this.Mass) ;
        }

        public abstract void LookAt();
        
    }
}
