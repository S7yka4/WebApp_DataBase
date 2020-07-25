using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Managers.Features
{
    public class CreateOrUpdateFeatureRequest
    {
        protected Guid Id;
        protected double WarrantyDuration;//в годах
        protected double Power;
        protected double Weight;

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

        public double warrantyduration
        {
            get
            {
                return WarrantyDuration;
            }
            set
            {
                WarrantyDuration = value;
            }
        }
        public double power
        {
            get
            {
                return Power;
            }
            set
            {
                Power = value;
            }
        }
        public double weight
        {
            get
            {
                return Weight;
            }
            set
            {
                Weight = value;
            }
        }

    }
}
