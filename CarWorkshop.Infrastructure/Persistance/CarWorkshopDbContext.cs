using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Infrastructure.Persistance
{
    public class CarWorkshopDbContext: DbContext
    {
        public CarWorkshopDbContext(DbContextOptions<CarWorkshopDbContext> options) : base(options)
        {
            
        }
        public DbSet<Domain.Entitis.CarWorkshop> CarWorkshops { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Entitis.CarWorkshop>().OwnsOne(x => x.ContactDetails);


            //modelBuilder.Entity<Domain.Entitis.CarWorkshop>().Property(x => x.Name).IsRequired();
            //modelBuilder.Entity<Domain.Entitis.CarWorkshop>().Property(x => x.CreateAt).HasDefaultValue(DateTime.UtcNow);
            //modelBuilder.Entity<Domain.Entitis.CarWorkshop>().OwnsOne(x => x.ContactDetails);
        }
    }
}
