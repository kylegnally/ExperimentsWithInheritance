using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class UtilityDroid : Droid
    {
        protected bool toolBox;
        protected bool computerConnection;
        protected bool arm;

        //protected decimal optionsCost;

        protected const decimal TOOLBOX_COST = 15.0m;
        protected const decimal COMPUTER_CONNECTION_COST = 20.0m;
        protected const decimal ARM_COST = 10.0m;

        public override decimal TotalCost
        {
            //get => BaseCost + optionsCost;
            get => BaseCost;
            set => BaseCost = value;
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
            if (toolBox) TotalCost += TOOLBOX_COST;
            if (computerConnection) TotalCost += COMPUTER_CONNECTION_COST;
            if (arm) TotalCost += ARM_COST;
            //CalculateOptions(toolBox, computerConnection, arm);
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

        //private void CalculateOptions(bool toolBox, bool computerConnection, bool arm)
        //{
        //    if (toolBox) optionsCost += TOOLBOX_COST;
        //    if (computerConnection) optionsCost += COMPUTER_CONNECTION_COST;
        //    if (arm) optionsCost += ARM_COST;
        //}

        public override void CalculateTotalCost()
        {
            //if (toolBox) TotalCost += TOOLBOX_COST;
            //if (computerConnection) TotalCost += COMPUTER_CONNECTION_COST;
            //if (arm) TotalCost += ARM_COST;
            //TotalCost = BaseCost + optionsCost;
        }
    }
}
