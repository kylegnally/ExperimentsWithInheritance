namespace cis237_assignment3
{
    public class ProtocolDroid : Droid
    {
        private int numberOfLanguages;
        private const decimal COST_PER_LANGUAGE = 15.00m;

        public override decimal TotalCost
        {
            get => BaseCost; // this is why TotalCost is increasing. DONT! 
            set => BaseCost = value;
        }

        public ProtocolDroid(
            string material, 
            string color, 
            int numberOfLanguages) : base (material, color)
        {
            this.numberOfLanguages = numberOfLanguages;
        }

        public override string ToString()
        {
            return base.ToString() + " " + TotalCost.ToString("C") + " " + numberOfLanguages + " languages";
        }

        public override void CalculateTotalCost()
        {
            if (base.Material == "Polyskin") BaseCost += 15.0m;
            if (base.Material == "Metaskin") BaseCost += 25.0m;
            if (base.Material == "Ceraskin") BaseCost += 50.0m;
            if (base.Color == "Black") BaseCost += 10.0m;
            if (base.Color == "Red") BaseCost += 30.0m;
            if (base.Color == "White") BaseCost += 50.0m;
            TotalCost = BaseCost + (numberOfLanguages * COST_PER_LANGUAGE);
        }
    }
}
