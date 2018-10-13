namespace cis237_assignment3
{
    public abstract class Droid : IDroid
    {
        // Basic costs for all droids
        private const decimal UNIT_BASE_COST = 20.00m;
        private const decimal POLYSKIN_MAT_COST = 15.0m;
        private const decimal METASKIN_MAT_COST = 25.0m;
        private const decimal CERASKIN_MAT_COST = 50.0m;
        private const decimal COLOR_BLACK_COST = 10.0m;
        private const decimal COLOR_RED_COST = 10.0m;
        private const decimal COLOR_WHITE_COST = 10.0m;

        // properties shared by all droids
        private string Material { get; }
        private string Color { get; }
        protected decimal BaseCost { get; set; }
        public abstract decimal TotalCost { get; set; }

        // constructor
        protected Droid(string material, string color)
        {
            BaseCost = UNIT_BASE_COST;
            this.Material = material;
            this.Color = color;
            CalculateSubtotal();
        }

        // subtotal method used to add skin and color costs to the base cost
        private void CalculateSubtotal()
        {
            if (this.Material == "Polyskin") BaseCost += POLYSKIN_MAT_COST;
            if (this.Material == "Metaskin") BaseCost += METASKIN_MAT_COST;
            if (this.Material == "Ceraskin") BaseCost += CERASKIN_MAT_COST;
            if (this.Color == "Black") BaseCost += COLOR_BLACK_COST;
            if (this.Color == "Red") BaseCost += COLOR_RED_COST;
            if (this.Color == "White") BaseCost += COLOR_WHITE_COST;
        }

        // Returns the color and material strings
        public virtual string DroidInformation()
        {
            return Color + " " + Material + " ";
        }

        // returns the basic droid information
        public override string ToString()
        {
            return DroidInformation();
        }

        // abstract method to return total cost. Implemented in child classes
        public abstract void CalculateTotalCost();
    }
}
