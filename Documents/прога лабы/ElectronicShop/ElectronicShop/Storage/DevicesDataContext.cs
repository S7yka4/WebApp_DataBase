
using ElectronicShop.Storage.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicShop.Storage
{
    public class DevicesDataContext: DbContext
    {

        public DevicesDataContext(DbContextOptions<DevicesDataContext> options): base(options)
        {

        }

        public DbSet<Device> Devices { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BattaryFeature> BattaryFeatures { get; set; }
        public DbSet<Cost> Costs { get; set; }
        public DbSet<ResponsibleConsultant> ResponsibleConsultants { get; set; }
        public DbSet<PlaceInTop> PlacesInTop { get; set; }


    }
}
