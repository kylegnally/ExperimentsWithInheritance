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

#region Menus
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

        public string MaterialSelection()
        {
            Console.ResetColor();
            menuString = "\n\n\n\n\n\t\t\t\t--- SELECT A MATERIAL TYPE ---\n\n" +
                         "\t\t\t\t(P) Polyskin \n" +
                         "\t\t\t\t(M) Metaskin\n" +
                         "\t\t\t\t(C) Ceraskin\n";
            return menuString;
        }

        public string ColorSelection()
        {
            Console.Clear();
            Console.ResetColor();
            menuString = "\n\n\n\n\n\t\t\t\t--- SELECT A COLOR ---\n\n" +
                         "\t\t\t\t(B) Black \n" +
                         "\t\t\t\t(R) Red\n" +
                         "\t\t\t\t(W) White\n";
            return menuString;
        }

        #endregion

#region Utility Methods
        /// <summary>
        /// Message displayed when the user prints the beverage list.
        /// </summary>
        /// <returns>string</returns>
        public string PrintListMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string printListMessage = "\n\n\t\t\t\t--- DROID INVENTORY ---\n\n";
            return printListMessage;
        }

        public void PrintDroidList(string[] allDroids)
        {
            Console.ResetColor();
            for (int i = 0; i < allDroids.Length; i++)
            {
                if (allDroids[i] != null)
                {
                    Console.WriteLine(allDroids[i]);
                }
            }
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

#endregion

#region output messages

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

        public string NotANumberMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string invalidOption = "\n\n\t\t\t\tThat doesn't seem to be an integer. Please enter a number (1, 5, 3, etc.).";
            invalidOption += "\n\n\t\t\t\tDROID NOT ADDED. Please Re-enter this droids information, making certain";
            invalidOption += "\n\t\t\t\tthat you enter a number for the number of languages desired.";
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

        #endregion

#region Droid Build Methods

        public string[] BuildProtocolDroid()
        {
            string material = ChooseDroidMaterial();
            string color = ChooseDroidColor();
            string languages = ChooseDroidLanguages();
            return new[] {material, color, languages};
        }

        public string[] BuildAUtilityDroid()
        {
            string material = ChooseDroidMaterial();
            string color = ChooseDroidColor();
            string toolbox = ChooseToolboxOption();
            string compcnxn = ChooseComputerConnectionOption();
            string arm = ChooseArmOption();

            return new[] { material, color, toolbox, compcnxn, arm };
        }

        public string[] BuildAJanitorDroid()
        {
            string[] janitorDroidBasics = BuildAUtilityDroid();
            string[] janitorDroidSpecifics = ChooseJanitorDroidSpecifics();
            string[] janitorDroid = janitorDroidBasics.Concat(janitorDroidSpecifics).ToArray();
            return janitorDroid;
        }

        public string[] BuildAnAstromechDroid()
        {
            string[] astromechDroidBasics = BuildAUtilityDroid();
            string[] astromechSpecifics = ChooseAstromechDroidSpecifics();
            string[] astromechDroid = astromechDroidBasics.Concat(astromechSpecifics).ToArray();
            return astromechDroid;
        }

        #endregion

#region Droid Options Methods

        private string ChooseDroidLanguages()
        {
            int number;
            Console.ResetColor();
            Console.Write("\n\n\t\t\t\t");
            Console.Write("How many languages would you like to support? ");
            string languages = Console.ReadLine();
            return languages;
        }
        
        private string ChooseDroidMaterial()
        {
            Console.Clear();
            Console.Write(MaterialSelection());
            Console.Write("\n\n\t\t\t\t");
            string material = DetermineMaterial();
            return material;
        }

        private string ChooseDroidColor()
        {
            Console.Clear();
            Console.Write(ColorSelection());
            Console.Write("\n\n\t\t\t\t");
            string color = DetermineColor();
            return color;
        }

        private string ChooseToolboxOption()
        {
            Console.Write("\n\n\t\t\t\t");
            Console.Write("Would you like to add a toolbox to this model (Y/N)? ");
            string toolboxChoice = Console.ReadLine().ToUpper();
            switch (toolboxChoice)
            {
                case "Y":
                    toolboxChoice = "true";
                    break;
                case "N":
                    toolboxChoice = "false";
                    break;
                default:
                    Console.Write(InvalidOptionMessage());
                    Pause();
                    BuildAUtilityDroid();
                    break;
            }

            return toolboxChoice;
        }

        private string ChooseArmOption()
        {
            Console.Write("\n\n\t\t\t\t");
            Console.Write("Would you like to add a utility arm to this model (Y/N)? ");
            string arm = Console.ReadLine().ToUpper();
            switch (arm)
            {
                case "Y":
                    arm = "true";
                    break;
                case "N":
                    arm = "false";
                    break;
                default:
                    Console.Write(InvalidOptionMessage());
                    Pause();
                    ChooseArmOption();
                    break;
            }

            return arm;
        }

        private string ChooseComputerConnectionOption()
        {
            Console.Write("\n\n\t\t\t\t");
            Console.Write("Would you like to add a computer connection to this model (Y/N)? ");
            string compcnxn = Console.ReadLine().ToUpper();
            switch (compcnxn)
            {
                case "Y":
                    compcnxn = "true";
                    break;
                case "N":
                    compcnxn = "false";
                    break;
                default:
                    Console.Write(InvalidOptionMessage());
                    Pause();
                    ChooseComputerConnectionOption();
                    break;
            }

            return compcnxn;
        }

        private string[] ChooseJanitorDroidSpecifics()
        {
            Console.Write("\n\n\t\t\t\t");
            Console.Write("Would you like to add a vacuum to this model (Y/N)? ");
            string vacuumChoice = Console.ReadLine().ToUpper();
            switch (vacuumChoice)
            {
                case "Y":
                    vacuumChoice = "true";
                    break;
                case "N":
                    vacuumChoice = "false";
                    break;
                default:
                    Console.Write(InvalidOptionMessage());
                    Pause();
                    BuildAUtilityDroid();
                    break;
            }

            Console.Write("\n\n\t\t\t\t");
            Console.Write("Would you like to add a trash compactor to this model (Y/N)? ");
            string compactorChoice = Console.ReadLine().ToUpper();
            switch (compactorChoice)
            {
                case "Y":
                    compactorChoice = "true";
                    break;
                case "N":
                    compactorChoice = "false";
                    break;
                default:
                    Console.Write(InvalidOptionMessage());
                    Pause();
                    BuildAUtilityDroid();
                    break;
            }

            return new[] {vacuumChoice, compactorChoice};
        }

        private string[] ChooseAstromechDroidSpecifics()
        {
            Console.Write("\n\n\t\t\t\t");
            Console.Write("Would you like to add a fire extinguisher to this model (Y/N)? ");
            string extinguisherChoice = Console.ReadLine().ToUpper();
            switch (extinguisherChoice)
            {
                case "Y":
                    extinguisherChoice = "true";
                    break;
                case "N":
                    extinguisherChoice = "false";
                    break;
                default:
                    Console.Write(InvalidOptionMessage());
                    Pause();
                    BuildAUtilityDroid();
                    break;
            }

            Console.Write("\n\n\t\t\t\t");
            Console.Write("How many ships would you like to support? ");
            string ships = Console.ReadLine();
            int number;
            while (!int.TryParse(ships, out number))
            {
                Console.WriteLine(NotANumberMessage());
                ships = Console.ReadLine();
            }

            return new[] {extinguisherChoice, ships};
        }

        private string DetermineMaterial()
        {
            Console.ResetColor();
            string material = Console.ReadLine().ToUpper();
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
                    ChooseDroidMaterial();
                    break;
            }

            return material;
        }

        private string DetermineColor()
        {
            Console.ResetColor();
            string color = Console.ReadLine().ToUpper();
            switch (color)
            {
                case "B":
                    color = "Black";
                    break;
                case "R":
                    color = "Red";
                    break;
                case "W":
                    color = "White";
                    break;
                default:
                    Console.Write(InvalidOptionMessage());
                    Pause();
                    ChooseDroidColor();
                    break;
            }

            return color;
        }

#endregion
        
    }
}

