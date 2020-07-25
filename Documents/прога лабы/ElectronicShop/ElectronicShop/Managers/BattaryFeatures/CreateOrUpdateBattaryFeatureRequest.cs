using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Managers.BattaryFeatures
{
    public class CreateOrUpdateBattaryFeatureRequest
    {

        protected Guid Id;
        protected int BattaryCapacity;
        protected double Voltage;
        protected int CurrentOutput;
        public Guid FeatureId;
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
        public int battaryCapacity
        {
            get
            {
                return BattaryCapacity;
            }
            set
            {
                BattaryCapacity = value;
            }
        }
        public double voltage
        {
            get
            {
                return Voltage;
            }
            set
            {
                Voltage = value;
            }
        }
        public int currentOutput
        {
            get
            {
                return CurrentOutput;
            }
            set
            {
                CurrentOutput = value;
            }
        }

    }
}
