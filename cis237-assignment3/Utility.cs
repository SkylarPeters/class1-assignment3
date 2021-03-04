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
    class Utility : Droid
    {
        //*****************************
        // Variables
        //*****************************
        private bool toolbox;
        private bool computerConnection;
        private bool arm;
        private decimal utilityCostCalc;

        //*****************************
        // Constants
        //*****************************
        private const decimal utilityTypeCost = 100;

        //*****************************
        //Properties
        //*****************************
        public bool Toolbox
        {
            get { return toolbox; }
            set { toolbox = value; }
        }

        public bool ComputerConnection
        {
            get { return computerConnection; }
            set { computerConnection = value; }
        }

        public bool Arm
        {
            get { return arm; }
            set { arm = value; }
        }

        public override decimal TotalCost
        {
            get { return utilityCostCalc; }
        }


        //******************************
        // Public Methods
        //******************************
        public override string ToString()
        {
            return $"{base.ToString()}Toolbox Equipped: {Toolbox.ToString()}" + Environment.NewLine +
                   $"Computer Connection Equipped: {ComputerConnection.ToString()}" + Environment.NewLine +
                   $"Extra Arm Equipped: {Arm.ToString()}";
        }

        // Method to override CalculateTotalCost
        public override void CalculateTotalCost()
        {
            if (Toolbox == true)
            {
                utilityCostCalc += 100;
            }
            if (ComputerConnection == true)
            {
                utilityCostCalc += 100;
            }
            if (Arm == true)
            {
                utilityCostCalc += 100;
            }    
            utilityCostCalc += base.TotalCost + utilityTypeCost;
        }

        //*****************************
        // Constructors
        //*****************************
        public Utility(string Material, string Color, bool Toolbox, bool ComputerConnection, bool Arm)
            : base(Material, Color)
        {
            this.toolbox = Toolbox;
            this.computerConnection = ComputerConnection;
            this.arm = Arm;
        }

        public Utility()
        {

        }
    }
}
