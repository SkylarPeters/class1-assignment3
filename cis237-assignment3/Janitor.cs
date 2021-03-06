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
    class Janitor : Utility
    {
        //*****************************
        // Variables
        //*****************************
        private bool trashCompactor;
        private bool vacuum;
        private decimal janitorCostCalc;

        //*****************************
        // Constants
        //*****************************
        private const decimal janitorTypeCost = 50;

        //*****************************
        //Properties
        //*****************************
        public bool TrashCompactor
        {
            get { return trashCompactor; }
            set { trashCompactor = value; }
        }

        public bool Vacuum
        {
            get { return vacuum; }
            set { vacuum = value; }
        }

        //******************************
        // Public Methods
        //******************************
        public override string ToString()
        {
            return $"{base.ToString()}" + Environment.NewLine + 
                   $"Trash Compactor Equipped: {TrashCompactor.ToString()}" + Environment.NewLine +
                   $"Vacuum Equipped: {Vacuum.ToString()}";
        }

        // Method to override CalculateTotalCost
        public override void CalculateTotalCost()
        {
            if (TrashCompactor == true)
            {
                janitorCostCalc += 100;
            }
            if (Vacuum == true)
            {
                janitorCostCalc += 100;
            }
            janitorCostCalc += base.TotalCost + janitorTypeCost;
        }

        //*****************************
        // Constructors
        //*****************************
        public Janitor(string Material, string Color, bool Toolbox, bool ComputerConnection, bool Arm, bool TrashCompactor, bool Vacuum)
            : base(Material, Color, Toolbox, ComputerConnection, Arm)
        {
            this.trashCompactor = TrashCompactor;
            this.vacuum = Vacuum;
        }

        public Janitor()
        {

        }
    }
}
