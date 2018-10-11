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
        public string BaseCost { get; set; }
        public decimal TotalCost { get; set; }

        public void CalculateTotalCost()
        {
            throw new NotImplementedException();
        }

    }
}
