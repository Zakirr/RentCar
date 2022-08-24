using Entities.Concrete;
using Girilenler.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Melumatlar.Concrete
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder opbuilder)
        {
            //opbuilder.UseSqlServer(@"(localdb)\MSSQLLocalDB;Database=ReCarDatabase;Trusted_Connection=true");
            opbuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ReCarDatabase;Trusted_Connection=true");
        }

        public DbSet<Car> Car { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<CarImages> CarImages { get; set; }
        //public DbSet<Customers> Customers { get; set; }
        public DbSet<Rentals> Rentals { get; set; }
    }
}
