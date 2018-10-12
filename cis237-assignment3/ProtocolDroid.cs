﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    public class ProtocolDroid : Droid
    {
        private int numberOfLanguages;
        protected const decimal COST_PER_LANGUAGE = 15.00m;

        public override decimal TotalCost
        {
            get => BaseCost + (numberOfLanguages * COST_PER_LANGUAGE);
            set { }
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
            TotalCost = BaseCost + UNIT_BASE_COST + (numberOfLanguages * COST_PER_LANGUAGE);
        }
    }
}
