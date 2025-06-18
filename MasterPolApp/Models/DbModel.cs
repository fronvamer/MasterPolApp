using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MasterPolApp.Models
{
    public partial class DbModel : DbContext
    {
        public DbModel()
            : base("name=DbModel")
        {
        }

        public virtual DbSet<PartnerProducts> PartnerProducts { get; set; }
        public virtual DbSet<Partners> Partners { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductTypes> ProductTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Partners>()
                .HasMany(e => e.PartnerProducts)
                .WithRequired(e => e.Partners)
                .HasForeignKey(e => e.PartnerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.PartnerProducts)
                .WithRequired(e => e.Products)
                .HasForeignKey(e => e.ProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductTypes>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.ProductTypes)
                .HasForeignKey(e => e.ProductTypeId)
                .WillCascadeOnDelete(false);
        }
    }
}
