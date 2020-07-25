using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Storage.Entity
{
    public class ResponsibleConsultant:IUniqueKey
    {
        [Key]
        [Required]
        [Column("GuidId")]
        protected Guid Id;
        [Required]
        [Column("StrName")]
        [MaxLength(15)]
        protected string Name;
        [Required]
        [Column("DoubMark")]
        protected double Mark;
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
