using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class AstromechDroid : UtilityDroid
    {
        private const string NAME = "Astromech Droid";

        private bool fireExtinguisher;
        private int numberOfShips;

        private const decimal EXTINGUISHER_COST = 35.0m;
        private const decimal SHIPS_COST = 50.0m;

        public override decimal TotalCost { get; set; }

        public AstromechDroid(
            string material,
            string color,
            bool toolBox,
            bool computerConnection,
            bool arm,
            bool fireExtinguisher,
            int numberOfShips) : base (
            material,
            color,
            toolBox,
            computerConnection,
            arm)
        {
            this.fireExtinguisher = fireExtinguisher;
            this.numberOfShips = numberOfShips;
        }

        public override string ToString()
        {
            return base.ToString() 
                   + " "
                   + NAME
                   + " "
                   + " extinguisher: "
                   + fireExtinguisher
                   + " ships: "
                   + numberOfShips
                   + " "
                   + " PRICE:   "
                   + TotalCost.ToString("C"); ;
        }

        public override void CalculateTotalCost()
        {
            if (fireExtinguisher) BaseCost += EXTINGUISHER_COST;
            BaseCost += (numberOfShips * SHIPS_COST);
            TotalCost = BaseCost;
        }
    }
}
