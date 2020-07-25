using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Managers.Costs
{
    public class CreateOrUpdateCostRequest
    {
        protected Guid Id;
        protected double CostInDollars;
        protected double CostInRub;
        public Guid DeviceId;
        public Guid id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        public double costInDollars
        {
            get
            {
                return CostInDollars;
            }
            set
            {
                CostInDollars = value;
            }
        }
        public double costInRub
        {
            get
            {
                return CostInRub;
            }
            set
            {
                CostInRub = value;
            }
        }
    }
}
