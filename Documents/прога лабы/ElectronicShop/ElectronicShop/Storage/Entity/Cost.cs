using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Storage.Entity
{
    public class Cost:IUniqueKey
    {
        [Key]
        [Required]
        [Column("GuidId")]
        protected Guid Id;
        [Required]
        [Column("DoubCostInDollars")]
        protected double CostInDollars;
        [Required]
        [Column("DoubCostInRub")]
        protected double CostInRub;

        [Required]
        [Column("DeviceId")]
        public Guid DeviceId;
        [ForeignKey(nameof(DeviceId))]
        public Device Device { get; set; }

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
