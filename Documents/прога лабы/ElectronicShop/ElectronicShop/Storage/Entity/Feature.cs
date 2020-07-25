using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Storage.Entity
{
    public class Feature:IUniqueKey
    {
        [Key]
        [Required]
        [Column("GuidId")]
        protected Guid Id;
        [Required]
        [Column("DoubWarrantyDuration")]
        protected double WarrantyDuration;//в годах

        [Required]
        [Column("DoubPower")]
        protected double Power;
        [Required]
        [Column("DoubWeight")]
        protected double Weight;

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

        public Feature()
        {
            WarrantyDuration = 0;
            Power = 0;
            Weight = 0;
        }

        public Feature(double dur,  double pow, double weight)
        {
            WarrantyDuration = dur;
            Power = pow;
            Weight = weight;
        }
        public Feature(Feature tmp)
        {
            WarrantyDuration = tmp.WarrantyDuration;
            Power = tmp.Power;
            Weight = tmp.Weight;
        }

        public void RedactFeature(double dur = -1,  double pow = -1, double weight = -1)
        {
            if (dur != -1)
                WarrantyDuration = dur;
            if (pow != -1)
                Power = pow;
            if (weight != -1)
                Weight = weight;
        }
    }
}
