using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Managers.Devices
{
    public class CreateOrUpdateDeviceRequest
    {
        protected Guid Id;
        protected string Name;
        protected int Count;

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

        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public int count
        {
            get
            {
                return Count;
            }
            set
            {
                Count = value;
            }
        }

    }
}
