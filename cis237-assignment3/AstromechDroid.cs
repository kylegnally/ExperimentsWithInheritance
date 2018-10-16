/***************************************************************************
 *
 * Kyle Nally
 * CIS237 T/Th 3:30pm Assignment 3 - Inheritance and Polymorphism
 * 10/16/18
 *
 ***************************************************************************/

namespace cis237_assignment3
{
    class AstromechDroid : UtilityDroid
    {

        private bool fireExtinguisher;
        private int numberOfShips;
        private const string NAME = "Astromech Droid";

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
            this.Name = NAME;
            this.fireExtinguisher = fireExtinguisher;
            this.numberOfShips = numberOfShips;
        }

        public override string ToString()
        {
            return base.ToString()
                   + " "
                   + " extinguisher: "
                   + fireExtinguisher
                   + " ships: "
                   + numberOfShips;
            //+ " "
            //+ " PRICE:   "
            //+ TotalCost.ToString("C"); ;
        }

        public override void CalculateTotalCost()
        {
            if (fireExtinguisher) BaseCost += EXTINGUISHER_COST;
            BaseCost += (numberOfShips * SHIPS_COST);
            TotalCost = BaseCost;
        }
    }
}
