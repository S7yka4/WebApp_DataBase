using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Storage.Entity
{
    public class PlaceInTop:IUniqueKey
    {
        [Key]
        [Required]
        [Column("GuidId")]
        protected Guid Id;
        [Required]
        [Column("IntMiddleAge")]
        protected int MiddleAge;
        [Required]
        [Column("IntHighAge")]
        protected int HighAge;
        [Required]
        [Column("IntLowAge")]
        protected int LowAge;
        [Required]
        [Column("CategoryId")]
        public Guid CategoryId;
        [ForeignKey(nameof(CategoryId))]
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
