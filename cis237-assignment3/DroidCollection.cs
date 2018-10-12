using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class DroidCollection
    {
        Droid[] droids;
        int collectionPosition;

        /// <summary>
        /// Creates a new droids array of type Beverage and of the size passed into it.
        /// Sets the initial position of the array counter to 0 (the beginning of the array).
        /// </summary>
        /// <param name="collectionSize"></param>
        public DroidCollection()
        {
            droids = new Droid[100];
            collectionPosition = 0;
        }
        
        // There should be four Add methods here - one for each Droid type
        //public void Add(string id, string desc, string pack, decimal price, bool active)
        //{
        //    droids[collectionPosition] = new Droid(id, desc, pack, price, active);
        //    collectionPosition++;
        //}

        public void Add(string material, string color, int numberOfLanguages)
        {
            droids[collectionPosition] = new ProtocolDroid(material, color, numberOfLanguages);
            collectionPosition++;
        }

        /// <summary>
        /// Prints the entire inventory of droids using the ToString() override method of the Beverage class.
        /// Returns the entire inventory as a string[].
        /// </summary>
        /// <returns>string[]</returns>
        public string[] PrintTheDroidsInventory()
        {
            string[] allDroids = new string[collectionPosition];

            for (int i = 0; i < droids.Length; i++)
            {
                if (droids[i] != null)
                {
                    allDroids[i] = "\t\t\t\t" + droids[i].ToString();
                }
            }

            return allDroids;
        }
    }
}
