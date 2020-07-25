using ElectronicShop.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Managers.ResponsibleConsultants
{
    public class CreateOrUpdateResponsibleConsultantRequest
    {

        protected Guid Id;
        protected string Name;
        protected double Mark;
        public Guid CategoryId;
        public Category Category { get; set; }
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
        public double mark
        {
            get
            {
                return Mark;
            }
            set
            {
                Mark = value;

            }
        }
    }
}
