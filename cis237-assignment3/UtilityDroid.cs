using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class UtilityDroid : Droid
    {
        private bool toolBox;
        private bool computerConnection;
        private bool arm;

        private const decimal TOOLBOX_COST = 15.0m;
        private const decimal COMPUTER_CONNECTION_COST = 20.0m;
        private const decimal ARM_COST = 10.0m;

        public override decimal TotalCost { get; set; }

        public UtilityDroid(
            string material, 
            string color, 
            bool toolBox, 
            bool computerConnection, 
            bool arm) : base (material, color)
        {
            this.toolBox = toolBox;
            this.computerConnection = computerConnection;
            this.arm = arm;
            CalculateSubtotal();
        }

        public override string ToString()
        {
            return base.ToString() 
                   + " " 
                   + TotalCost.ToString("C") 
                   + " " + " toolbox: " 
                   + toolBox 
                   + " computer connection: " 
                   + computerConnection 
                   + " arm: " 
                   + arm;
        }

        private void CalculateSubtotal()
        {
            if (this.toolBox) BaseCost += TOOLBOX_COST;
            if (this.computerConnection) BaseCost += COMPUTER_CONNECTION_COST;
            if (this.arm) BaseCost += ARM_COST;
        }

        public override void CalculateTotalCost()
        {
            TotalCost = BaseCost;
        }
    }
}
