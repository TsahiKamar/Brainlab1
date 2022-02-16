using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Infrastructure.Internal;
using System.Collections.Generic;

namespace Brainlab1.DataAccess
{
    public class AppDbContext : DbContext
    {
        public DbSet<GeneralInfo> generalInfo { get; set; }
        public DbSet<PriceList> prices { get; set; }

        public DbSet<Employees> employees { get; set; }
        public DbSet<Customers> customers { get; set; }

        public DbSet<Cars> cars { get; set; }
        public DbSet<CarService> carService { get; set; }
        public DbSet<CarReplacementParts> carReplacementParts { get; set; }
        public DbSet<Invoices> invoices { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<General>()
           .Property(b => b.customer).HasColumnName("Customer");

            modelBuilder.Entity<General>()
           .Property(b => b.assignEmployees).HasColumnName("AssignEmployees");

            modelBuilder.Entity<General>()
           .Property(b => b.partsUsed).HasColumnName("PartsUsed");
         
            modelBuilder.Entity<General>()
           .Property(b => b.phones).HasColumnName("Phones");

            modelBuilder.Entity<GeneralInfo>().ToTable("GeneralInfo");
            modelBuilder.Entity<PriceList>().ToTable("PriceList");
            modelBuilder.Entity<Employees>().ToTable("Employees");
            modelBuilder.Entity<Customers>().ToTable("Customers");
            modelBuilder.Entity<Cars>().ToTable("Cars");
            modelBuilder.Entity<CarService>().ToTable("CarService");
            modelBuilder.Entity<CarReplacementParts>().ToTable("CarReplacementParts");
            modelBuilder.Entity<Invoices>().ToTable("Invoices");

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = "data source=.;initial catalog=MyNewDb;integrated security=true";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }



    }

}
