using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    public class ProtocolDroid : Droid
    {
        private int numberOfLanguages;

        private const decimal UNIT_BASE_COST = 20.00m;
        //protected const decimal COST_PER_LANGUAGE = 15.00m;
        protected const string DROID_TYPE = "Protocol";

        public override decimal TotalCost
        {
            get { return (UNIT_BASE_COST); }
            set {  }
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
            return base.ToString() + " " + TotalCost.ToString("C");
        }

        public override void CalculateTotalCost()
        {
            TotalCost = TotalCost + BaseCost;
        }
    }
}
