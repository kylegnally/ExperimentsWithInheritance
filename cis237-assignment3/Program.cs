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
            string menuChoice = null;
            string outputString = "";
            UserInterface aMenu = new UserInterface();
            DroidCollection collection = new DroidCollection();

            void DisplayMenu()
            {
                Console.Clear();
                Console.Write(aMenu.DisplayMenu());
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
                        // Print the list. Burp if the list isn't loaded yet.
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
                        }
                        aMenu.Pause();
                        DisplayMenu();

                        break;
                    
                    case "A":
                        // Add to the list. Burp if the list isn't loaded yet.
                        if (!csvProcessor.listIsLoaded)
                        {
                            Console.Write(aMenu.CannotAddUntilLoaded());
                            aMenu.Pause();
                        }
                        else
                        {
                            string[] beverageToAdd = aMenu.AddABeverage();
                            if (sodaStand.FindBeverageById(beverageToAdd[0]) == null)
                            {
                                sodaStand.AddABeverage(beverageToAdd[0], beverageToAdd[1], beverageToAdd[2], decimal.Parse(beverageToAdd[3]), bool.Parse(beverageToAdd[4]));
                                Console.Write(aMenu.BeverageAdded());
                                aMenu.Pause();
                            }
                            else
                            {
                                Console.Write(aMenu.BeverageExists());
                                aMenu.Pause();
                            }
                        }
                        aMenu.Pause();
                        DisplayMenu();
                        break;
                    // Quit the program. Quits regardless of whether the list is loaded. Never burps.
                    case "Q":
                        Console.WriteLine(aMenu.QuitProgramMessage());
                        aMenu.Pause();
                        Environment.Exit(0);
                        break;

                    // The default option is invoked for any choices not on the menu. This may be an invalid
                    // entry or a blank entry. In either case, error is shown in red and the menu is simply redrawn.
                    default:
                        aMenu.InvalidOptionMessage();
                        aMenu.Pause();
                        DisplayMenu();
                        break;
                }
            }


            //IDroid[] droids = new IDroid[10];
            ////droids[0] = new ProtocolDroid("Polyskin", "Black", 3); // 90
            ////droids[1] = new ProtocolDroid("Metaskin", "Black", 2); // 85
            ////droids[2] = new ProtocolDroid("Ceraskin", "White", 1); // 135
            ////droids[3] = new ProtocolDroid("Polyskin", "Red", 4); // 125
            ////droids[4] = new UtilityDroid("Ceraskin", "Red", true, true, false); // 135
            ////droids[5] = new JanitorDroid("Polyskin", "Black", true, false, false, true, false); // 75
            //droids[6] = new AstromechDroid("Polyskin", "White", true, false, false, true, 3);

            //foreach (Droid droid in droids)
            //{
            //    if (droid != null)
            //    {
            //        // show me the money!
            //        droid.CalculateTotalCost();

            //        //Concat to the outputString
            //        outputString += droid.ToString() +
            //                        Environment.NewLine;
            //    }
            //}

            //Use the UI class to print out the string
            aMenu.Output(outputString);
            System.Threading.Thread.Sleep(5000);
        }
    }
}
