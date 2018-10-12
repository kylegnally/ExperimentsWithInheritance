namespace cis237_assignment3
{
    public abstract class Droid : IDroid
    {
        protected const decimal UNIT_BASE_COST = 20.00m;

        public string Material { get; set; }
        public string Color { get; set; }
        public decimal BaseCost { get; set; }
        public abstract decimal TotalCost { get; set; }

        protected Droid(string material, string color)
        {
            BaseCost = UNIT_BASE_COST;
            this.Material = material;
            this.Color = color;
            CalculateSkinAndColorCost(material, color);
        }

        private void CalculateSkinAndColorCost(string material, string color)
        {
            if (material == "Polyskin") BaseCost += 15.0m;
            if (material == "Metaskin") BaseCost += 25.0m;
            if (material == "Ceraskin") BaseCost += 50.0m;
            if (color == "Black") BaseCost += 10.0m;
            if (color == "Red") BaseCost += 30.0m;
            if (color == "White") BaseCost += 50.0m;
        }

        public virtual string DroidInformation()
        {
            return Material + " " + Color + " ";
        }

        public override string ToString()
        {
            return DroidInformation();
        }

        public abstract void CalculateTotalCost();
    }
}
