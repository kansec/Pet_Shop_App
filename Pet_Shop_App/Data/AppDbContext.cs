using Microsoft.EntityFrameworkCore;
using Pet_Shop_App.Models;

namespace Pet_Shop_App.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Operation_Vet>().HasKey(o => new
            {
                o.OperationId,
                o.VetId
            });

            modelBuilder.Entity<Operation_Vet>().HasOne(t => t.Operation).WithMany(o => o.Operations_Vets).HasForeignKey(t => t.OperationId);
            modelBuilder.Entity<Operation_Vet>().HasOne(t => t.Vet).WithMany(o => o.Operations_Vets).HasForeignKey(t => t.VetId);

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Operation> Operations { get; set; }
        public DbSet<Owner> Owners { get; set; }

        public DbSet<Pet> Pets { get; set; }

        public DbSet<PetCategory> PetCategories { get; set; }

        public DbSet<Treatment> Treatments { get; set; }

        public DbSet<Vet> Vets { get; set; }
        public DbSet<Operation_Vet> OperationsVets { get; set; }


    }
}
