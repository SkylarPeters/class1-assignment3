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
    class Program
    {
        static void Main(string[] args)
        {
            // New instance of the User Interface and Droid Collection classes
            UserInterface ui = new UserInterface();
            DroidCollection dc = new DroidCollection();

            //Get some input from the user
            int choice = ui.GetUserInput();

            // While the choice is not 3, continue.
            while (choice != 3)
            {
                // Check if input is 1
                if (choice == 1)
                {

                }
                if (choice == 2)
                {

                }

            }
        }
    }
}
