using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Storage.Entity
{
    public class Category:IUniqueKey
    {
        [Key]
        [Required]
        [Column("GuidId")]
        protected Guid Id;
        [Required]
        [Column("StrNameOfCategory")]
        [MaxLength(15)]
        protected string NameOfCategory;

        [Required]
        [Column("DeviceId")]// id группы необходимый для связки
        public Guid DeviceId;
        [ForeignKey(nameof(DeviceId))]//внешний ключ говорит о том чтоэта колонка является внешним ключем
        public Device device { get; set; }

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

        
  

        public Category(string name)
        {
            NameOfCategory = name;
        }
        public Category()
        {
            NameOfCategory = "-";
        }
        public Category(Category tmp)
        {
            NameOfCategory = tmp.NameOfCategory;
        }

        public void RedactCategory(string namecat = "--")
        {
            if (namecat != "--")
                NameOfCategory = namecat;

        }
    }
}
