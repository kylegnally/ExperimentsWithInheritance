using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class JanitorDroid : UtilityDroid
    {
        private bool trashCompactor;
        private bool vacuum;

        private const decimal TRASH_COST = 15.0m;
        private const decimal VAC_COST = 15.0m;

        public override decimal TotalCost
        {
            get => BaseCost;
            set => BaseCost = value;
        }

        public JanitorDroid(
            string material,
            string color,
            bool toolBox,
            bool computerConnection,
            bool arm,
            bool trashCompactor,
            bool vacuum) : base (
                material,
                color,
                toolBox,
                computerConnection,
                arm)
        {
            this.trashCompactor = trashCompactor;
            this.vacuum = vacuum;
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
                   + arm + " trash compactor " 
                   + trashCompactor 
                   + " vacuum " 
                   + " ";
        }

        public override void CalculateTotalCost()
        {
            //if (toolBox) TotalCost += TOOLBOX_COST;
            //if (computerConnection) TotalCost += COMPUTER_CONNECTION_COST;
            //if (arm) TotalCost += ARM_COST;
            if (trashCompactor) TotalCost += TRASH_COST;
            if (vacuum) TotalCost += VAC_COST;
            //TotalCost = BaseCost + optionsCost;
        }
    }
}
