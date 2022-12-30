using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;


namespace Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Owner>().Property(x => x.ID).HasDefaultValueSql("newid()");
            modelBuilder.Entity<PortfolioItem>().Property(x => x.ID).HasDefaultValueSql("newid()");
            modelBuilder.Entity<Owner>().HasData(
                new Owner()
                {
                    ID = Guid.NewGuid(),
                    Avatar = "Avatar.jpg",
                    FullName = "Ahmed Elsayed Moustafa",
                    Profile = ".Net Full Stack Developer"
                }
                );

        }

        public DbSet<Owner> owner { get; set; }
        public DbSet<PortfolioItem> portfolioItem { get; set; }
    }
}
