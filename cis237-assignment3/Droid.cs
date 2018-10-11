using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    abstract class Droid : IDroid
    {
        public string Material { get; set; }
        public string Color { get; set; }
        public decimal BaseCost { get; set; }
        public decimal TotalCost { get; set; }

        public Droid(string Material, string Color)
        {
            this.Material = Material;
            this.Material = Color;
        }

        public void CalculateTotalCost()
        {
            throw new NotImplementedException();
        }

    }
}
