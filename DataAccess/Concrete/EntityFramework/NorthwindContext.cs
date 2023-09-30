using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: Db tabloları ile proje classlarını bağlamak
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Hangi veritanaına bağlanılacak o yazılır
            //Normal projelerde Ip adresi yazılır --> mesela 175.45.2.12 gibi
            //Fakat şuan development ortamında olduğumuz için localdekini alırız
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=NorthwindDatabase;Trusted_Connection=true");


        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
