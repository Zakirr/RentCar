using Girilenler.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
