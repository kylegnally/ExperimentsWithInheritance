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

        private decimal optionsCost;

        private const decimal TOOLBOX_COST = 15.0m;
        private const decimal COMPUTER_CONNECTION_COST = 20.0m;
        private const decimal ARM_COST = 10.0m;

        public override decimal TotalCost
        {
            get => BaseCost + optionsCost;
            set { }
        }

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
            CalculateOptions(toolBox, computerConnection, arm);
        }

        public override string ToString()
        {
            return base.ToString() + " " + 
                   TotalCost.ToString("C") + " " 
                   + " toolbox: " + toolBox.ToString() + 
                " computer connection: " 
                + computerConnection.ToString() + 
                   " arm: " + arm.ToString();
        }

        private void CalculateOptions(bool tool, bool comp, bool arm)
        {
            if (tool) optionsCost += TOOLBOX_COST;
            if (comp) optionsCost += COMPUTER_CONNECTION_COST;
            if (arm) optionsCost += ARM_COST;
        }

        public override void CalculateTotalCost()
        {
            TotalCost = BaseCost + optionsCost;
        }
    }
}
