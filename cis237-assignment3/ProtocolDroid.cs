using System.Dynamic;

namespace cis237_assignment3
{
    class ProtocolDroid : Droid
    {

        private int numberOfLanguages;

        private const decimal COST_PER_LANGUAGE = 15.00m;
        private const string NAME = "Prtocol Droid";

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
