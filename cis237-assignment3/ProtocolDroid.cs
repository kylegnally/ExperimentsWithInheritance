/***************************************************************************
 *
 * Kyle Nally
 * CIS237 T/Th 3:30pm Assignment 3 - Inheritance and Polymorphism
 * 10/16/18
 *
 ***************************************************************************/

namespace cis237_assignment3
{
    class ProtocolDroid : Droid
    {

        private int numberOfLanguages;

        private const decimal COST_PER_LANGUAGE = 15.00m;
        private const string NAME = "Protocol Droid";

        public override decimal TotalCost { get; set; }

        public ProtocolDroid(
            string material, 
            string color, 
            int numberOfLanguages) : base (material, color)
        {
            this.numberOfLanguages = numberOfLanguages;
            this.Name = NAME;
        }

        public override string ToString()
        {
            return base.ToString()
                   + " "
                   + " languages: "
                   + numberOfLanguages;
            //+ " " 
            //+ " PRICE:   " 
            //+ TotalCost.ToString("C");
        }

        public override void CalculateTotalCost()
        {
            TotalCost = BaseCost + (numberOfLanguages * COST_PER_LANGUAGE);
        }
    }
}
