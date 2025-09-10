using ObjectOrientedProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject.DataAccessLayer.Context
{
    public class CampContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }   

        public DbSet<Customer> Customers { get; set; } 

        public DbSet<Admin> Admins { get; set; }

    }
}





// DbSet in yanında yazan Category csharp ekranında olacak isim
// Categories ismi ise bizim sql üzerine yansıyacak olan isim.