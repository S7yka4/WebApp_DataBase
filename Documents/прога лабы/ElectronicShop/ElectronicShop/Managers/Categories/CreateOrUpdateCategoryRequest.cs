using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Managers.Categories
{
    public class CreateOrUpdateCategoryRequest
    {
        protected Guid Id;
        protected string NameOfCategory;
        public  Guid DeviceId;
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
        public string nameofcategory
        {
            get
            {
                return NameOfCategory;
            }
            set
            {
                NameOfCategory = value;
            }
        }
    }
}
