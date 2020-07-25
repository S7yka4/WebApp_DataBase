using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Storage
{
    interface IUniqueKey
    {

        [Key]
        [Required]
        [Column("GuidId")]
        public Guid id{ get; set; }

        
    }
}
