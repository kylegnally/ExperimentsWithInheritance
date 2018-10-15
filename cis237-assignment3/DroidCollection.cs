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

        public DroidCollection()
        {
            droids = new Droid[100];
            collectionPosition = 0;
        }

        public void Add(string material, 
            string color, 
            int numberOfLanguages)
        {
            droids[collectionPosition] = new ProtocolDroid(
                material, 
                color, 
                numberOfLanguages);
            droids[collectionPosition].CalculateTotalCost();
            collectionPosition++;
        }

        public void Add(
            string material,
            string color,
            bool toolBox,
            bool computerConnection,
            bool arm)
        {
            droids[collectionPosition] = new UtilityDroid(
                material, 
                color, 
                toolBox, 
                computerConnection, 
                arm);
            droids[collectionPosition].CalculateTotalCost();
            collectionPosition++;
        }

        public void Add(
            string material,
            string color,
            bool toolBox,
            bool computerConnection,
            bool arm,
            bool trashCompactor,
            bool vacuum)
        {
            droids[collectionPosition] =
                new JanitorDroid(material, 
                    color, 
                    toolBox, 
                    computerConnection, 
                    arm, 
                    trashCompactor, 
                    vacuum);
            droids[collectionPosition].CalculateTotalCost();
            collectionPosition++;
        }

        public void Add(
            string material,
            string color,
            bool toolBox,
            bool computerConnection,
            bool arm,
            bool fireExtinguisher,
            int numberOfShips)
        {
            droids[collectionPosition] =
                new AstromechDroid(material,
                    color,
                    toolBox,
                    computerConnection,
                    arm,
                    fireExtinguisher,
                    numberOfShips);
            droids[collectionPosition].CalculateTotalCost();
            collectionPosition++;
        }

        public string[] PrintTheDroidsInventory()
        {
            string[] allDroids = new string[collectionPosition];

            for (int i = 0; i < droids.Length; i++)
            {
                if (droids[i] != null)
                {
                    allDroids[i] = droids[i].ToString();
                }
            }

            return allDroids;
        }
    }
}
