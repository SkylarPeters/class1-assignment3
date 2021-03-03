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
    class Protocol : Droid
    {
        //*****************************
        // Variables
        //*****************************
        private int numberOfLanguages;
        private decimal protocolCostCalc;

        //*****************************
        // Constants
        //*****************************
        private const decimal costPerLanguage = 100;
        private const decimal protocolTypeCost = 150;

        //*****************************
        //Properties
        //*****************************
        public int NumberOfLanguages
        {
            get { return numberOfLanguages; }
            set { numberOfLanguages = value; }
        }

        public override decimal TotalCost
        {
            get { return protocolCostCalc; }
        }

        //******************************
        // Public Methods
        //******************************
        public override string ToString()
        {
            return $"{base.ToString()} {NumberOfLanguages.ToString()}";
        }

        public override void CalculateTotalCost()
        {
            protocolCostCalc = base.TotalCost + protocolTypeCost + (numberOfLanguages * costPerLanguage);
        }

        //*****************************
        // Constructors
        //*****************************
        public Protocol(string Material, string Color, int NumberOfLanguages) : base(Material, Color)
        {
            this.numberOfLanguages = NumberOfLanguages;
        }
    }
}
