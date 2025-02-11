using CarWorkshop.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Infrastructure.Seeders
{
    public class CarWorkshopSeeder
    {
        private readonly CarWorkshopDbContext _dbcontext;

        public CarWorkshopSeeder(CarWorkshopDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public async Task Seed()
        {
            if (await _dbcontext.Database.CanConnectAsync())
            {
                if (!_dbcontext.CarWorkshops.Any())
                {
                    var mazdaAso = new Domain.Entitis.CarWorkshop()
                    {
                        Name = "Mazda ASO",
                        Description = "Autoryzowany serwis samochodowy Mazda",
                        CreateAt = DateTime.UtcNow,
                        ContactDetails = new Domain.Entitis.CarWorkshopContactDetails()
                        {
                            City = "Kraków",
                            Street = "ul. Karmelicka 46",
                            PostalCode = "31-128",
                            PhoneNumber = "12 123 45 67"
                        }
                    };
                    mazdaAso.EncodeName();
                    _dbcontext.CarWorkshops.Add(mazdaAso);
                    await _dbcontext.SaveChangesAsync();
                }
            }
        }
    }
}
