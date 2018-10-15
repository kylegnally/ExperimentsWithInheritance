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
                        ChooseDroidType();
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

            void ChooseDroidType()
            {
                Console.Clear();
                Console.ResetColor();
                aMenu.DroidSelection();
                Console.Write("\n\n\t\t\t\t");
                string droidType = Console.ReadLine().ToUpper();
                switch (droidType)
                {
                    case "P":
                        string[] protocol = aMenu.BuildProtocolDroid();
                        collection.Add(protocol[0], protocol[1], int.Parse(protocol[2]));
                        Console.WriteLine(aMenu.DroidAdded());
                        break;
                    case "U":
                        string[] utility = aMenu.BuildAUtilityDroid();
                        collection.Add(utility[0], utility[1], bool.Parse(utility[2]), bool.Parse(utility[3]), bool.Parse(utility[4]));
                        Console.WriteLine(aMenu.DroidAdded());
                        break;
                    case "J":
                        string[] janitor = aMenu.BuildAJanitorDroid();
                        collection.Add(janitor[0], janitor[1], bool.Parse(janitor[2]), bool.Parse(janitor[3]), bool.Parse(janitor[4]), bool.Parse(janitor[5]), bool.Parse(janitor[6]));
                        Console.WriteLine(aMenu.DroidAdded());
                        break;
                    case "A":
                        string[] astromech = aMenu.BuildAnAstromechDroid();
                        collection.Add(astromech[0], astromech[1], bool.Parse(astromech[2]), bool.Parse(astromech[3]), bool.Parse(astromech[4]), bool.Parse(astromech[5]), int.Parse(astromech[6]));
                        Console.WriteLine(aMenu.DroidAdded());
                        break;
                    default:
                        Console.WriteLine(aMenu.InvalidOptionMessage());
                        aMenu.Pause();
                        ChooseDroidType();
                        break;
                }
                aMenu.Pause();
                DisplayMainMenu();
            }
        }
    }
}
