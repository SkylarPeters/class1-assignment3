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
                    dc.PrintArray();
                }

                // Check if input is 2
                if (choice == 2)
                {
                    ui.PrintDroidOptions();
                    string input = Console.ReadLine();

                    // While the input is not valid re-get the input
                    while (input != "1" &&
                           input != "2" &&
                           input != "3" &&
                           input != "4")
                    {
                        //Print Error message
                        ui.PrintErrorMessage();

                        //Re-print the options
                        ui.PrintDroidOptions();

                        //Get the input from the console again.
                        input = Console.ReadLine();
                    }
                    // Switch statement to add new droids to the list.
                    switch (input)
                    {
                        // Adds a protocol droid
                        case "1":
                            string[] newPDroidInformation = ui.GetNewProtocolDroid();
                            dc.AddNewProtocolDroid(newPDroidInformation[0],
                                                   newPDroidInformation[1],
                                                   int.Parse(newPDroidInformation[2]));
                            break;

                        // Adds a utility droid
                        case "2":
                            string[] newUDroidInformation = ui.GetNewUtilityDroid();
                            dc.AddNewUtilityDroid(newUDroidInformation[0],
                                                  newUDroidInformation[1],
                                                  newUDroidInformation[2] == "True",
                                                  newUDroidInformation[3] == "True",
                                                  newUDroidInformation[4] == "True");
                            break;

                        // Adds a janitor droid
                        case "3":
                            string[] newJDroidInformation = ui.GetNewJanitorDroid();
                            dc.AddNewJanitorDroid(newJDroidInformation[0],
                                                  newJDroidInformation[1],
                                                  newJDroidInformation[2] == "True",
                                                  newJDroidInformation[3] == "True",
                                                  newJDroidInformation[4] == "True",
                                                  newJDroidInformation[5] == "True",
                                                  newJDroidInformation[6] == "True");
                            break;

                        // Adds an astromech droid
                        case "4":
                            string[] newADroidInformation = ui.GetNewAstromechDroid();
                            dc.AddNewAstromechDroid(newADroidInformation[0],
                                                  newADroidInformation[1],
                                                  newADroidInformation[2] == "True",
                                                  newADroidInformation[3] == "True",
                                                  newADroidInformation[4] == "True",
                                                  newADroidInformation[5] == "True",
                                                  int.Parse(newADroidInformation[6]));
                            break;
                    }
                }
                choice = ui.GetUserInput();
            }
        }
    }
}
