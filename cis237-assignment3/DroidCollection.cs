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
    class DroidCollection
    {
        // New instance of the User Interface class
        UserInterface ui = new UserInterface();

        // Instantiation of the array
        IDroid[] droids = new IDroid[100];
        private int droidLength = 0;

        //*************************
        // Methods
        //*************************
        // Add a new droid
        public void AddNewProtocolDroid(string material, 
                                        string color, 
                                        int numberOfLanguages)
        {
            droids[droidLength] = new Protocol(material, color, numberOfLanguages);
            droidLength++;
        }

        public void AddNewUtilityDroid(string material, 
                                       string color, 
                                       bool toolbox, 
                                       bool computerConnection, 
                                       bool arm)
        {
            droids[droidLength] = new Utility(material, color, toolbox, computerConnection, arm);
            droidLength++;
        }

        public void AddNewJanitorDroid(string material, 
                                       string color, 
                                       bool toolbox, 
                                       bool computerConnection, 
                                       bool arm, 
                                       bool trashCompactor, 
                                       bool vacuum)
        {
            droids[droidLength] = new Janitor(material, color, toolbox, computerConnection, arm, trashCompactor, vacuum);
            droidLength++;

        }

        public void AddNewAstromechDroid(string material,
                               string color,
                               bool toolbox,
                               bool computerConnection,
                               bool arm,
                               bool fireExtinguisher,
                               int numberShips)
        {
            droids[droidLength] = new Astromech(material, color, toolbox, computerConnection, arm, fireExtinguisher, numberShips);
            droidLength++;
        }

        public void PrintArray()
        {
            // String to be concated to
            string outputString = "";

            // Print out the droids in the array
            foreach (IDroid droid in droids)
            {
                if (droid != null)
                {
                    // Concat to the outputString
                    outputString += droid.ToString() + Environment.NewLine;
                }
            }
            // Output the string
            ui.Output(outputString);
        }
    }
}
