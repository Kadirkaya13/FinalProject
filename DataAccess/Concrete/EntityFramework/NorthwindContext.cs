using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //defualt şemayı belirmek için kullanılan kod
            //modelBuilder.HasDefaultSchema("dbo");
            //"dbo" zorunlu değildir fakat farklı şemalar kullanılan bir veritabanından veri çekilecekse hangi şema olduğu belirtilmelidir
            //belirtilmemişsse default şemadan veri alınır
            modelBuilder.Entity<Personel>().ToTable("Employees");
            modelBuilder.Entity<Personel>().Property(p=>p.Id).HasColumnName("EmployeeID");
            modelBuilder.Entity<Personel>().Property(p=>p.Name).HasColumnName("FirstName");
            modelBuilder.Entity<Personel>().Property(p=>p.Surname).HasColumnName("LastName");
        }

    }
}
