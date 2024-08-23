using EF_Session1.Configuration;
using EF_Session1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Session1.Context
{

    //DB context = container of Database
    //          Deal with DB through it
    //         App can have more than one DBContext so can deal with many DB
    internal class EnterPriseDbContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)//fluent API


        {

            modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfiguration());

            //modelBuilder.Entity<Employee>().HasKey(E=>E.EmpID);
            //modelBuilder.Entity<Employee>().Property(nameof(Employee.EmpID)).UseIdentityColumn(1,1);
            //modelBuilder.Entity<Employee>().Property(E=> E.Name)
            //                               .HasColumnType("Varchar").HasMaxLength(50).HasDefaultValue("Ahmed");

            //modelBuilder.Entity<Employee>().Property(E => E.Salary).HasColumnType("money");


            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer(" Data Source = . ; Initial Catalog = EnterPrise ; Integerated Security = true");// old [EF]

            optionsBuilder.UseSqlServer("Server = . ; DataBase = EnterPrise ; Trusted_Connection = true ; Encrypt = False");//connection

        }

        public DbSet<Employee> Employees {  get; set; }//By convention will turn this class to table
        public DbSet<Department> Departments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Projects> Projects { get; set; }



        public EnterPriseDbContext() : base()
        {

        }
    }
}
