using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GiamSatHeThongThuyTinh_Web.Models
{
    public partial class GiamSatHeThongThuyTinhDbContext : DbContext
    {
        public GiamSatHeThongThuyTinhDbContext()
            : base("name=GiamSatHeThongThuyTinhDbContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Efficiency> Efficiencies { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductOfDay> ProductOfDays { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
