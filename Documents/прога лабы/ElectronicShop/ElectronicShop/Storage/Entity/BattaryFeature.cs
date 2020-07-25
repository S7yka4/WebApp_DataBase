using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Storage.Entity
{
    public class BattaryFeature:IUniqueKey
    {
        [Key]
        [Required]
        [Column("GuidId")]
        protected Guid Id;
        [Required]
        [Column("IntBattaryCapacity")]
        protected int BattaryCapacity;
        [Required]
        [Column("DoubVoltage")]
        protected double Voltage;
        [Required]
        [Column("IntCurrentOutput")]
        protected int CurrentOutput;

        [Required]
        [Column("FeaturesId")]// id группы необходимый для связки
        public Guid FeatureId;
        [ForeignKey(nameof(FeatureId))]
        public Feature Feature { get; set; }

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
                CurrentOutput=value;
            }
        }

    }
}
