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
            IDroid[] droids = new IDroid[10];
            droids[0] = new ProtocolDroid("Polyskin", "Red", 3);
            droids[1] = new ProtocolDroid("Metaskin", "Black", 2);
            droids[2] = new ProtocolDroid("Ceraskin", "White", 1);
            droids[3] = new ProtocolDroid("Polyskin", "Red", 4);
            droids[4] = new ProtocolDroid("Metaskin", "Red", 7);

            foreach (Droid droid in droids)
            {
                if (droid != null)
                {
                    //Concat to the outputString
                    outputString += droid.ToString() +
                                    Environment.NewLine;
                }
            }

            //Use the UI class to print out the string
            aMenu.Output(outputString);
            System.Threading.Thread.Sleep(2500);

        }
    }
}
