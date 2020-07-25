using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ElectronicShop.Storage.Entity
{
    [Table("tblDevice")]
    public class Device:IUniqueKey
    {
        
        [Key]//атрибут говорящий об этом поле в качестве айди ключа м помощью которого сущности будут связаны по смыслу 
        [Required]//отвечает за обязательность заполненности поля
        [Column("GuidId")]
        protected Guid Id;
        

        [Required]
        [Column("StrName")]
        [MaxLength(15)]
        protected string Name;
        
        [Required]
        [Column("IntCount")]
        protected int Count;

        ///группа


       

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

        public Device()
        {
            Name = "-";
            Count = 0;
        }
        public Device(string name, double cost, int count)
        {
            Name = name;
            Count = count;
        }
        public Device(Device tmp)
        {
            Name = tmp.Name;
   
            Count = tmp.Count;
        }

        public void RedactDevice(string name = "--", int count = -1)
        {
            if (name != "--")
                Name = name;

            if (count != -1)
                Count = count;


        }
    }
}
