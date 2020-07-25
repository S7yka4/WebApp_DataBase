using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Managers.PlacesInTop
{
    public class CreateOrUpdatePlaceInTopRequest
    {

        protected Guid Id;
        protected int MiddleAge;
        protected int HighAge;
        protected int LowAge;
        public Guid CategoryId;
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
        public int middleAge
        {
            get
            {
                return MiddleAge;
            }
            set
            {
                MiddleAge = value;
            }
        }
        public int highAge
        {
            get
            {
                return HighAge;
            }
            set
            {
                HighAge = value;
            }
        }
        public int lowAge
        {
            get
            {
                return LowAge;
            }
            set
            {
                LowAge = value;
            }
        }
    }
}
