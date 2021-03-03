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
            while (input != "1" && input != "2" && input != "3")
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

        private void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List of Droids");
            Console.WriteLine("2. Add New Droid to List");
            Console.WriteLine("3. Exit");
        }

        private void PrintErrorMessage()
        {
            Console.WriteLine("That is not a valid entry");
            Console.WriteLine("Please make a valid choice");
            Console.WriteLine();
        }

    }
}
