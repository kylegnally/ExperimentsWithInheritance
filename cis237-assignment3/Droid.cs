using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    public abstract class Droid : IDroid
    {
        public string Material { get; set; }
        public string Color { get; set; }
        public decimal BaseCost { get; set; }
        public abstract decimal TotalCost { get; set; }

        public Droid(string Material, string Color)
        {
            this.Material = Material;
            this.Color = Color;
        }

        public virtual string DroidInformation()
        {
            return Material + " " + Color + " " + TotalCost;
        }

        public override string ToString()
        {
            return DroidInformation();
        }

        public abstract void CalculateTotalCost();

    }
}
