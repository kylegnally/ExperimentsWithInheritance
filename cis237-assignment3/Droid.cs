using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    public abstract class Droid : IDroid
    {
        protected const decimal UNIT_BASE_COST = 20.00m;

        public string Material { get; set; }
        public string Color { get; set; }
        public decimal BaseCost { get; set; }
        public abstract decimal TotalCost { get; set; }

        protected Droid(string Material, string Color)
        {
            this.Material = Material;
            this.Color = Color;
            if (Material == "Polyskin") BaseCost += 15.0m;
            if (Material == "Metaskin") BaseCost += 25.0m;
            if (Material == "Ceraskin") BaseCost += 50.0m;
            if (Color == "Black") BaseCost += 10.0m;
            if (Color == "Red") BaseCost += 30.0m;
            if (Color == "White") BaseCost += 50.0m;
            //CalculateTotalCost();
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
