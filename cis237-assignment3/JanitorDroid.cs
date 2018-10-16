/***************************************************************************
 *
 * Kyle Nally
 * CIS237 T/Th 3:30pm Assignment 3 - Inheritance and Polymorphism
 * 10/16/18
 *
 ***************************************************************************/

namespace cis237_assignment3
{
    class JanitorDroid : UtilityDroid
    {

        private bool trashCompactor;
        private bool vacuum;
        private const string NAME = "Janitor Droid";
       
        private const decimal TRASH_COST = 15.0m;
        private const decimal VAC_COST = 15.0m;

        public override decimal TotalCost { get; set; }

        public JanitorDroid(
            string material,
            string color,
            bool toolBox,
            bool computerConnection,
            bool arm,
            bool trashCompactor,
            bool vacuum) : base (
                material,
                color,
                toolBox,
                computerConnection,
                arm)
        {
            this.Name = NAME;
            this.trashCompactor = trashCompactor;
            this.vacuum = vacuum;
        }

        public override string ToString()
        {
            return base.ToString()
                   + " "
                   + " compactor: "
                   + trashCompactor
                   + " vacuum: "
                   + vacuum;
            //+ " " 
            //+ " PRICE:   " 
            //+ TotalCost.ToString("C");
        }

        public override void CalculateTotalCost()
        {
            if (trashCompactor) BaseCost += TRASH_COST;
            if (vacuum) BaseCost += VAC_COST;
            TotalCost = BaseCost;
        }
    }
}
