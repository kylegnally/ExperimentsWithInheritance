using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string menuChoice = null;
            string droidTypeChoice = null;

            string outputString = "";
            UserInterface aMenu = new UserInterface();
            DroidCollection collection = new DroidCollection();
            DisplayMainMenu();

            void DisplayMainMenu()
            {
                Console.Clear();
                Console.Write(aMenu.MainMenu());
                Console.Write("\n\n\t\t\t\t");
                menuChoice = Console.ReadLine();
                HandleInput(menuChoice);
            }

            void HandleInput(string userSelection)
            {
                userSelection = userSelection.ToUpper();
                switch (userSelection)
                {

                    case "P":
                        aMenu.PrintListMessage();
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
                        Console.Clear();
                        aMenu.DroidSelection();
                        aMenu.Pause();
                        DisplayMainMenu();
                        break;

                    case "Q":
                        Console.WriteLine(aMenu.QuitProgramMessage());
                        aMenu.Pause();
                        Environment.Exit(0);
                        break;

                    default:
                        aMenu.InvalidOptionMessage();
                        aMenu.Pause();
                        DisplayMainMenu();
                        break;
                }
            }
        }
    }
}
