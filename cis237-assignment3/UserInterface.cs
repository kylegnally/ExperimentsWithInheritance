using System;
using System.Collections.Generic;
using System.Linq;
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
        public string DisplayMenu()
        {
            Console.ResetColor();
            menuString = "\n\n\n\n\n\t\t\t\tWelcome to LookSir Droids!\n\n" +
                "\t\t\t\tPlease select an option: \n\n" +
                "\t\t\t\t(P) Print the beverage list\n" +
                "\t\t\t\t(A) Add a beverage to the beverage list\n" +
                "\t\t\t\t(Q) Quit\n\n";
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

