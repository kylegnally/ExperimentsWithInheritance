using System.Dynamic;

namespace cis237_assignment3
{
    public class ProtocolDroid : Droid
    {
        private const string NAME = "Protocol Droid";

        private int numberOfLanguages;

        private const decimal COST_PER_LANGUAGE = 15.00m;

        public override decimal TotalCost { get; set; }

        public ProtocolDroid(
            string material, 
            string color, 
            int numberOfLanguages) : base (material, color)
        {
            this.numberOfLanguages = numberOfLanguages;
        }

        public override string ToString()
        {
            return base.ToString() 
                   + " " 
                   + NAME 
                   + " "                    
                   + " languages: " 
                   + numberOfLanguages 
                   + " " 
                   + " PRICE:   " 
                   + TotalCost.ToString("C");
        }

        public override void CalculateTotalCost()
        {
            TotalCost = BaseCost + (numberOfLanguages * COST_PER_LANGUAGE);
        }
    }
}
