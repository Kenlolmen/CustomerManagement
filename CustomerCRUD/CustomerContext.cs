using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CustomerCRUD
{
    internal class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // Connection String
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; DataBase = CustomerManagementDataBase;" +
                " Trusted_Connection = true; MultipleActiveResultSets = true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // seed data
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { ID = 1, Name = "Aleksander Jaruga", Adress = "Zwyciestwa 13/5", Email = "AleksanderJaruga@gmail.com", PhoneNumber = 638456736, Budget = 60000 },
                new Customer { ID = 2, Name = "Michał Zielony", Adress = "Al.Piastow 12/7", Email = "MichałZielony@gmail.com", PhoneNumber = 823462374, Budget = 5000 },
                new Customer { ID = 3, Name = "Bartek Lubelski", Adress = "Michałów 98/8", Email = "BartekLubelski@gmail.com", PhoneNumber = 837282737, Budget = 25000 });
        }
    }
}
