using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class UserInterface
    {
        string menuString;


        /// <summary>
        /// Displays the program menu.
        /// Returns the menu as a string.
        /// </summary>
        /// <returns>string</returns>
        public string MainMenu()
        {
            Console.ResetColor();
            menuString = "\n\n\n\n\n\t\t\t\tWelcome to LookSir Droids!\n\n" +
                "\t\t\t\tPlease select an option: \n\n" +
                "\t\t\t\t(A) Add a droid to the list\n" +
                "\t\t\t\t(P) Print the list of droids currently in inventory\n" +
                "\t\t\t\t(Q) Quit\n\n";
            return menuString;
        }


        public string DroidSelection()
        {
            Console.ResetColor();
            Console.Write("\n\n\n\n\n\t\t\t\t--- SELECT A DROID TYPE ---\n\n" +
                          "\t\t\t\t(P) Protocol Droid \n" +
                          "\t\t\t\t(U) Utility Droid\n" +
                          "\t\t\t\t(J) Janitor Droid\n" +
                          "\t\t\t\t(A) Astromech Droid\n\n");
            return menuString;
        }

        /// <summary>
        /// Message displayed when the user prints the beverage list.
        /// </summary>
        /// <returns>string</returns>
        public string PrintListMessage()
        {
            string printListMessage = "\n\n\t\t\t\tYou chose to (P)rint the droid list.";
            return printListMessage;
        }

        public void PrintDroidList(string[] allDroids)
        {
            for (int i = 0; i < allDroids.Length; i++)
            {
                if (allDroids[i] != null)
                {
                    Console.WriteLine(allDroids[i]);
                }
            }
        }

        /// <summary>
        /// Message displayed when the user exits the program.
        /// </summary>
        /// <returns>string</returns>
        public string QuitProgramMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string searchListMessage = "\n\n\t\t\t\tExiting program.";
            return searchListMessage;
        }

        /// <summary>
        /// Message displayed when the user selects an invalid menu option.
        /// </summary>
        /// <returns>string</returns>
        public string InvalidOptionMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string invalidOption = "\n\n\t\t\t\tInvalid option. Please select a valid option from the menu.";
            return invalidOption;
        }

        /// <summary>
        /// Called if the user tries to print a list while the list is empty. Contains a suggestion to load the list. Returns a string.
        /// </summary>
        /// <returns>string</returns>
        public string NothingToPrint()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string printError = "\n\t\t\t\tThe list is empty. There are no droids to list.";
            return printError;
        }

        /// <summary>
        /// If called, informs the user that the beverage they have chosen to add has been successfully added to the collection. Returns a string.
        /// </summary>
        /// <returns>string</returns>
        public string DroidAdded()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string droidAdded = "\n\n\t\t\t\tNew droid added.";
            return droidAdded;
        }

        public string[] BuildProtocolDroid()
        {
            string material = GeneralMaterial();
            string color = GeneralColor();
            Console.Write("\n\n\t\t\t\t");
            Console.Write("How many languages would you like to support? ");
            string languages = Console.ReadLine();
            int number;
            while (!int.TryParse(languages, out number))
            {
                Console.WriteLine("That is not an integer. Please enter a number.");
                languages = Console.ReadLine();
            }
            return new[] {material, color, languages};
        }

        public string[] BuildUtilityDroid()
        {
            string material = GeneralMaterial();
            string color = GeneralColor();
            Console.Write("\n\n\t\t\t\t");
            Console.Write("Would you like to add a toolbox to this model (Y/N)? ");
            string toolboxChoice = Console.ReadLine();
            
            // continue adding switch elements
        }

        private string GeneralMaterial()
        {
            Console.Clear();
            Console.Write(MaterialSelection());
            Console.Write("\n\n\t\t\t\t");
            string materialMenuOption = Console.ReadLine().ToUpper();
            string material = DetermineMaterial(materialMenuOption);
            return material;
        }

        private string GeneralColor()
        {
            Console.Clear();
            Console.Write(ColorSelection());
            Console.Write("\n\n\t\t\t\t");
            string colorMenuOption = Console.ReadLine().ToUpper();
            string color = DetermineColor(colorMenuOption);
            return color;
        }

        
        
        private string DetermineMaterial(string material)
        {
            switch (material)
            {
                case "P":
                    material = "Polyskin";
                    break;
                case "M":
                    material = "Metaskin";
                    break;
                case "C":
                    material = "Ceraskin";
                    break;
                default:
                    Console.Write(InvalidOptionMessage());
                    Pause();
                    DetermineMaterial(material);
                    break;
            }

            return material;
        }

        private string DetermineColor(string color)
        {
            switch (color)
            {
                case "B":
                    color = "Black";
                    break;
                case "M":
                    color = "Red";
                    break;
                case "C":
                    color = "White";
                    break;
                default:
                    Console.Write(InvalidOptionMessage());
                    Pause();
                    DetermineMaterial(color);
                    break;
            }

            return color;
        }

        public string MaterialSelection()
        {
            menuString = "\n\n\n\n\n\t\t\t\t--- SELECT A MATERIAL TYPE ---\n\n" +
                         "\t\t\t\t(P) Polyskin \n" +
                         "\t\t\t\t(M) Metaskin\n" +
                         "\t\t\t\t(C) Ceraskin\n";
            return menuString;
        }

        public string ColorSelection()
        {
            menuString = "\n\n\n\n\n\t\t\t\t--- SELECT A COLOR ---\n\n" +
                         "\t\t\t\t(B) Black \n" +
                         "\t\t\t\t(R) Red\n" +
                         "\t\t\t\t(W) White\n";
            return menuString;
        }

        public string[] AddAProtocolDroid()
        {
            string material;
            string color;
            string lang;


            return new string[] { "Polyskin", "Black", "3" };
        }

        public string[] AddAUtilityDroid()
        {
            return new string[] { "Ceraskin", "Red", "true", "true", "false" };
        }

        public string[] AddAJanitorDroid()
        {
            return new string[] { "Polyskin", "Black", "false", "false", "true", "true", "false" };
        }

        public string[] AddAnAstromechDroid()
        {
            return new string[] { "Polyskin", "White", "true", "true", "false", "false", "3" };
        }

        /// <summary>
        /// Pauses execution by putting the currently running thread to sleep for 1500ms.
        /// </summary>
        public void Pause()
        {
            System.Threading.Thread.Sleep(1500);
        }

        public void Output(string outputString)
        {
            Console.WriteLine(outputString);
        }

    }
}

