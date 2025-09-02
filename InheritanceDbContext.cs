using Microsoft.EntityFrameworkCore;
using Part__02_Inheritance.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part__02_Inheritance
{
    public class InheritanceDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;DataBase=MyCompany02;Trusted_Connection=true;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region TPH
            //modelBuilder.Entity<FullTimeEmployee>()
            //    .HasBaseType<Employee>();
            //modelBuilder.Entity<PartTimeEmployee>()
            //   .HasBaseType<Employee>();
            // ------------------------
            //modelBuilder.Entity<Employee>()
            //    .HasDiscriminator<string>("EmployeeType").
            //    HasValue<FullTimeEmployee>("FTE")
            //    .HasValue<PartTimeEmployee>("PTE");
            #endregion
            #region TPT
            //modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployees");
            //modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployees");
            #endregion
        }
        #region TPC
        // public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        //public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; } 
        #endregion
        #region TPH
        // public DbSet<Employee> Employees { get; set; }
        // public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        // public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
        #endregion
        #region TPT
       // public DbSet<Employee> Employees { get; set; }
       // public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
      //  public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
        #endregion

    }
}
