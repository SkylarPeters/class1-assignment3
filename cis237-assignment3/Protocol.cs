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

        //*****************************
        // Constants
        //*****************************
        private const decimal costPerLanguage = 100;

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
            get { return base.totalCost; }
        }

        //******************************
        // Public Methods
        //******************************
        public override string ToString()
        {
            return $"{base.ToString()} {NumberOfLanguages.ToString("C")}";
        }

        public override void CalculateTotalCost()
        {
            base.TotalCost += (numberOfLanguages * costPerLanguage);
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
