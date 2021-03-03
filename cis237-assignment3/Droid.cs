﻿// Skylar Peters
// CIS 237
// 3/3/2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    abstract class Droid : IDroid
    {
        //*****************************
        // Variables
        //*****************************
        protected string material;
        protected string color;
        protected decimal totalCost;

        //*****************************
        // Properties
        //*****************************
        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public abstract decimal TotalCost { get; set; }

        //******************************
        // Public Methods
        //******************************
        // ToString method to return a formatted string containing the variables
        public override string ToString()
        {
            return $"{material} {color} {totalCost}";
        }

        public abstract void CalculateTotalCost();

        //*****************************
        // Constructors
        //*****************************
        public Droid(string Material, string Color)
        {
            this.material = Material;
            this.color = Color;
        }
    }
}
