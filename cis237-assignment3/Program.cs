﻿/***************************************************************************
 *
 * Kyle Nally
 * CIS237 T/Th 3:30pm Assignment 3 - Inheritance and Polymorphism
 * 10/16/18
 *
 ***************************************************************************/

using System;

namespace cis237_assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string menuChoice = null;
            string droidTypeChoice = null;

            string outputString = "";

            // instantiate the user interface
            UserInterface aMenu = new UserInterface();

            // instantiate the collection
            DroidCollection collection = new DroidCollection();
            DisplayMainMenu();

            // Main menu
            void DisplayMainMenu()
            {
                Console.Clear();
                Console.Write(aMenu.MainMenu());
                Console.Write("\n\n\t\t\t\t");
                menuChoice = Console.ReadLine();
                HandleMainMenuInput(menuChoice);
            }

            // droid menu
            void DisplayDroidMenu()
            {
                Console.Clear();
                Console.ResetColor();
                Console.Write(aMenu.DroidSelection());
                Console.Write("\n\n\t\t\t\t");
                string droidType = Console.ReadLine().ToUpper();
                HandleDroidMenuInput(droidType);
            }

            // main menu input handler
            void HandleMainMenuInput(string userSelection)
            {
                userSelection = userSelection.ToUpper();
                switch (userSelection)
                {

                    case "P":
                        Console.Write(aMenu.PrintListMessage());
                        if (collection == null)
                        {
                            Console.Write(aMenu.NothingToPrint());
                            aMenu.Pause();
                        }
                        else
                        {
                            string[] allDroids = collection.PrintTheDroidsInventory();
                            aMenu.PrintDroidList(allDroids);
                            aMenu.Pause();
                            
                        }
                        aMenu.Pause();
                        DisplayMainMenu();
                        break;

                    case "A":
                        DisplayDroidMenu();
                        break;

                    case "Q":
                        Console.WriteLine(aMenu.QuitProgramMessage());
                        aMenu.Pause();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine(aMenu.InvalidOptionMessage());
                        aMenu.Pause();
                        DisplayMainMenu();
                        break;
                }
            }

            // droid menu input handler
            void HandleDroidMenuInput(string droidType)
            {
                switch (droidType)
                {
                    case "P":
                        string[] protocol = aMenu.BuildProtocolDroid();
                        if (aMenu.ValidateDroidEntries(protocol))
                        {
                            collection.Add(protocol[0], protocol[1], int.Parse(protocol[2]));
                            Console.WriteLine(aMenu.DroidAdded());
                        }
                        else
                        {
                            InvalidInformation();
                        }
                        break;
                    case "U":
                        string[] utility = aMenu.BuildAUtilityDroid();
                        if (aMenu.ValidateDroidEntries(utility))
                        {
                            collection.Add(utility[0], utility[1], bool.Parse(utility[2]), bool.Parse(utility[3]), bool.Parse(utility[4]));
                            Console.WriteLine(aMenu.DroidAdded());
                        }
                        else
                        {
                            InvalidInformation();
                        }
                        break;
                    case "J":
                        string[] janitor = aMenu.BuildAJanitorDroid();
                        if (aMenu.ValidateDroidEntries(janitor))
                        {
                            collection.Add(janitor[0], janitor[1], bool.Parse(janitor[2]), bool.Parse(janitor[3]), bool.Parse(janitor[4]), bool.Parse(janitor[5]), bool.Parse(janitor[6]));
                            Console.WriteLine(aMenu.DroidAdded());
                        }
                        else
                        {
                            InvalidInformation();
                        }
                        break;
                    case "A":
                        string[] astromech = aMenu.BuildAnAstromechDroid();
                        if (aMenu.ValidateDroidEntries(astromech))
                        {
                            collection.Add(astromech[0], astromech[1], bool.Parse(astromech[2]), bool.Parse(astromech[3]), bool.Parse(astromech[4]), bool.Parse(astromech[5]), int.Parse(astromech[6]));
                            Console.WriteLine(aMenu.DroidAdded());
                        }
                        else
                        {
                            InvalidInformation();
                        }

                        break;
                    case "M":
                        DisplayMainMenu();
                        break;
                }
                aMenu.Pause();
                DisplayDroidMenu();
            }

            // The Badlands
            void InvalidInformation()
            {
                Console.Write(aMenu.InvalidInformation());
                aMenu.Pause();
                Console.ResetColor();
            }
        }
    }
}
