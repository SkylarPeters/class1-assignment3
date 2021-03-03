// Skylar Peters
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

        public virtual decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        //******************************
        // Public Methods
        //******************************
        // ToString method to return a formatted string containing the variables
        public override string ToString()
        {
            return $"{material} {color} {totalCost}";
        }

        public virtual void CalculateTotalCost()
        {
            // If statements used to add a cost to total based on color chosen
            if (Color == "Brown")
            {
                totalCost += 25;
            }
            if (Color == "White")
            {
                totalCost += 50;
            }
            if (Color == "Black")
            {
                totalCost += 75;
            }

            // If statements used to add a cost to total based on material chosen
            if (Material == "Iron")
            {
                totalCost += 100;
            }
            if (Material == "Steel")
            {
                totalCost += 200;
            }
            if (Material == "Titanium")
            {
                totalCost += 300;
            }
        }

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
