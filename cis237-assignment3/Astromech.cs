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
    class Astromech : Utility
    {
        //*****************************
        // Variables
        //*****************************
        private bool fireExtinguisher;
        private int numberShips;
        private decimal astromechCostCalc;

        //*****************************
        // Constants
        //*****************************
        private const decimal costPerShip = 25;
        private const decimal astromechTypeCost = 200;

        //*****************************
        //Properties
        //*****************************
        public bool FireExtinguisher
        {
            get { return fireExtinguisher; }
            set { fireExtinguisher = value; }
        }

        public int NumberShips
        {
            get { return numberShips; }
            set { numberShips = value; }
        }

        //******************************
        // Public Methods
        //******************************
        public override string ToString()
        {
            return $"{base.ToString()}" + Environment.NewLine + 
                   $"Fire Extinguisher Equipped: {FireExtinguisher.ToString()}" + Environment.NewLine +
                   $"Number of Ships Memorized: {NumberShips.ToString()}";
        }

        // Method to override CalculateTotalCost
        public override void CalculateTotalCost()
        {
            if (FireExtinguisher == true)
            {
                astromechCostCalc += 100;
            }
            astromechCostCalc += base.TotalCost + astromechTypeCost + (numberShips * costPerShip);
        }

        //*****************************
        // Constructors
        //*****************************
        public Astromech(string Material, string Color, bool Toolbox, bool ComputerConnection, bool Arm, bool FireExtinguisher, int NumberShips)
    : base(Material, Color, Toolbox, ComputerConnection, Arm)
        {
            this.fireExtinguisher = FireExtinguisher;
            this.numberShips = NumberShips;
        }

        public Astromech()
        {

        }
    }
}
