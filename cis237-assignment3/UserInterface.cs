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
    class UserInterface
    {
        //******************************
        //Methods
        //******************************
        public int GetUserInput()
        {
            //Print out a menu
            this.PrintMenu();

            //Get the input from the user
            String input = Console.ReadLine();

            //While the input is not valid re-get the input
            while (input != "1" && 
                   input != "2" && 
                   input != "3")
            {
                //Print Error message
                this.PrintErrorMessage();

                //Re-print the menu
                this.PrintMenu();

                //Get the input from the console again.
                input = Console.ReadLine();
            }

            return Int32.Parse(input);
        }

        // Print the menu to the user
        private void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List of Droids");
            Console.WriteLine("2. Add New Droid to List");
            Console.WriteLine("3. Exit");
        }

        // Print an error message to the user
        public void PrintErrorMessage()
        {
            Console.WriteLine("That is not a valid entry");
            Console.WriteLine("Please make a valid choice");
            Console.WriteLine();
        }

        // Method that writes the output to the screen
        public void Output(string outputString)
        {
            Console.WriteLine(outputString);
        }

        // Method to print droid selection options to user
        public void PrintDroidOptions()
        {
            Console.WriteLine("Enter the Corresponding Number to Choose Droid Type.");
            Console.WriteLine("1: Protocol" + Environment.NewLine + 
                              "2: Utility" + Environment.NewLine + 
                              "3: Janitor" + Environment.NewLine + 
                              "4: Astromech");
        }

        // Method to gather info for a protocol droid
        public string[] GetNewProtocolDroid()
        {
            // Variables used
            string material;
            string color;
            string numberOfLanguages;

            // Print question and get input
            material = this.GetStringField("Material? (Iron, Steel, or Titanium)");
            string input = material;

            // While the input is not a valid material, re-get the input
            while (input.ToLower() != "iron" &&
                   input.ToLower() != "steel" &&
                   input.ToLower() != "titanium")
            {
                // Print Error message
                this.PrintErrorMessage();

                // Re-print the question
                material = this.GetStringField("Material? (Iron, Steel, or Titanium)");

                // Get the input again
                input = material;
            }

            // Print question and get input
            color = this.GetStringField("Color? (Brown, White, or Black)");
            input = color;

            // While the input is not a valid color, re-get the input
            while (input.ToLower() != "brown" &&
                   input.ToLower() != "white" &&
                   input.ToLower() != "black")
            {
                // Print Error message
                this.PrintErrorMessage();

                // Re-print the question
                color = this.GetStringField("Color? (Brown, White, or Black)");

                // Get the input again.
                input = color;
            }
            // Print question for the number of known languages
            numberOfLanguages = this.GetIntField("Number of Languages");

            return new string[] { material, color, numberOfLanguages };
        }

        // Method to gather info for a utility droid
        public string[] GetNewUtilityDroid()
        {
            // Variables used
            string material;
            string color;
            string toolbox;
            string computerConnection;
            string arm;

            // Print question and get input
            material = this.GetStringField("Material? (Iron, Steel, or Titanium)");
            string input = material;

            // While the input is not a valid material, re-get the input
            while (input.ToLower() != "iron" &&
                   input.ToLower() != "steel" &&
                   input.ToLower() != "titanium")
            {
                // Print Error message
                this.PrintErrorMessage();

                // Re-print the question
                GetStringField("Material? (Iron, Steel, or Titanium)");

                // Get the input again.
                input = material;
            }

            // Print question and get input
            color = this.GetStringField("Color? (Brown, White, or Black)");
            input = color;

            // While the input is not a valid color, re-get the input
            while (input.ToLower() != "brown" &&
                   input.ToLower() != "white" &&
                   input.ToLower() != "black")
            {
                // Print Error message
                this.PrintErrorMessage();

                // Re-print the question
                GetStringField("Color? (Brown, White, or Black)");

                // Get the input from the console again.
                input = color;
            }

            // Print question for adding a toolbox, computer connection, and an arm
            toolbox = this.GetBoolField("Toolbox");
            computerConnection = this.GetBoolField("Computer Connection");
            arm = this.GetBoolField("Arm");

            return new string[] { material, color, toolbox, computerConnection, arm };
        }

        // Method to gather info for a janitor droid
        public string[] GetNewJanitorDroid()
        {
            // Variables used
            string material;
            string color;
            string toolbox;
            string computerConnection;
            string arm;
            string trashCompactor;
            string vacuum;

            // Print question and get input
            material = this.GetStringField("Material? (Iron, Steel, or Titanium)");
            string input = material;

            // While the input is not a valid material, re-get the input
            while (input.ToLower() != "iron" &&
                   input.ToLower() != "steel" &&
                   input.ToLower() != "titanium")
            {
                // Print Error message
                this.PrintErrorMessage();

                // Re-print the question
                GetStringField("Material? (Iron, Steel, or Titanium)");

                // Get the input again.
                input = material;
            }

            // Print question and get input
            color = this.GetStringField("Color? (Brown, White, or Black)");
            input = color;

            // While the input is not a valid color, re-get the input
            while (input.ToLower() != "brown" &&
                   input.ToLower() != "white" &&
                   input.ToLower() != "black")
            {
                // Print Error message
                this.PrintErrorMessage();

                // Re-print the question
                GetStringField("Color? (Brown, White, or Black)");

                // Get the input from the console again.
                input = color;
            }

            // Print question for adding a toolbox, computer connection, and an arm
            toolbox = this.GetBoolField("Toolbox");
            computerConnection = this.GetBoolField("Computer Connection");
            arm = this.GetBoolField("Arm");
            trashCompactor = this.GetBoolField("Trash Compactor");
            vacuum = this.GetBoolField("Vacuum");

            return new string[] { material, color, toolbox, computerConnection, arm, trashCompactor, vacuum };
        }

        // Method to gather info for an astromech droid
        public string[] GetNewAstromechDroid()
        {
            // Variables used
            string material;
            string color;
            string toolbox;
            string computerConnection;
            string arm;
            string fireExtinguisher;
            string numberShips;

            // Print question and get input
            material = this.GetStringField("Material? (Iron, Steel, or Titanium)");
            string input = material;

            // While the input is not a valid material, re-get the input
            while (input.ToLower() != "iron" &&
                   input.ToLower() != "steel" &&
                   input.ToLower() != "titanium")
            {
                // Print Error message
                this.PrintErrorMessage();

                // Re-print the question
                GetStringField("Material? (Iron, Steel, or Titanium)");

                // Get the input again.
                input = material;
            }

            // Print question and get input
            color = this.GetStringField("Color? (Brown, White, or Black)");
            input = color;

            // While the input is not a valid color, re-get the input
            while (input.ToLower() != "brown" &&
                   input.ToLower() != "white" &&
                   input.ToLower() != "black")
            {
                // Print Error message
                this.PrintErrorMessage();

                // Re-print the question
                GetStringField("Color? (Brown, White, or Black)");

                // Get the input from the console again.
                input = color;
            }

            // Print question for adding a toolbox, computer connection, and an arm
            toolbox = this.GetBoolField("Toolbox");
            computerConnection = this.GetBoolField("Computer Connection");
            arm = this.GetBoolField("Arm");
            fireExtinguisher = this.GetBoolField("Fire Extinguisher");
            numberShips = this.GetIntField("Number of Ships");

            return new string[] { material, color, toolbox, computerConnection, arm, fireExtinguisher, numberShips };
        }

        // Get a valid string field from the user
        private string GetStringField(string fieldName)
        {
            Console.WriteLine("What is the new Droid's {0}", fieldName);
            string value = null;
            bool valid = false;
            while (!valid)
            {
                value = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(value))
                {
                    valid = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You must provide a value.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("What is the new Droid's {0}", fieldName);
                    Console.Write("> ");
                }
            }
            return value;
        }

        // Get a valid in field from the user
        private string GetIntField(string fieldName)
        {
            Console.WriteLine("What is the new Droid's known {0}", fieldName);
            int value = 0;
            bool valid = false;
            while (!valid)
            {
                try
                {
                    value = Int32.Parse(Console.ReadLine());
                    valid = true;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid Integer. Please enter a valid Integer.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("What is the new Droid's known {0}", fieldName);
                    Console.Write("> ");
                }
            }
            return value.ToString();
        }

        // Get a valid bool field from the user
        private string GetBoolField(string fieldName)
        {
            Console.WriteLine("Should the Droid have a/an {0} (y/n)", fieldName);
            string input = null;
            bool value = false;
            bool valid = false;
            while (!valid)
            {
                input = Console.ReadLine();
                if (input.ToLower() == "y" || input.ToLower() == "n")
                {
                    valid = true;
                    value = (input.ToLower() == "y");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid Entry.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("Should the Droid have a/an {0} (y/n)", fieldName);
                    Console.Write("> ");
                }
            }
            return value.ToString();
        }
    }
}
