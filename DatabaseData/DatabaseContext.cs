using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DatabaseData
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<CustomerDemographics> CustomerDemographics { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<EmployeeTerritories> EmployeeTerritories { get; set; }
        public virtual DbSet<Order_Details> Order_Details { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Shippers> Shippers { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<Territories> Territories { get; set; }
        public virtual DbSet<Model.KPI> KPIs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerDemographics>()
                .Property(e => e.CustomerTypeID)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerDemographics>()
                .HasMany(e => e.Customers)
                .WithMany(e => e.CustomerDemographics)
                .Map(m => m.ToTable("CustomerCustomerDemo").MapLeftKey("CustomerTypeID").MapRightKey("CustomerID"));

            modelBuilder.Entity<Customers>()
                .Property(e => e.CustomerID)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.ContactName)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.ContactTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.Region)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.TitleOfCourtesy)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.Region)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.Extension)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.PhotoPath)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeTerritories>()
                .Property(e => e.TerritoryID)
                .IsUnicode(false);

            modelBuilder.Entity<Order_Details>()
                .Property(e => e.UnitPrice)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Orders>()
                .Property(e => e.CustomerID)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.Freight)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Orders>()
                .Property(e => e.ShipName)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.ShipAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.ShipCity)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.ShipRegion)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.ShipPostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.ShipCountry)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.Order_Details)
                .WithRequired(e => e.Orders)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.QuantityPerUnit)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.UnitPrice)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.Order_Details)
                .WithRequired(e => e.Products)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Region>()
                .Property(e => e.RegionDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Region>()
                .HasMany(e => e.Territories)
                .WithRequired(e => e.Region)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shippers>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<Shippers>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Shippers>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Shippers)
                .HasForeignKey(e => e.ShipVia);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.ContactName)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.ContactTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.Region)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Territories>()
                .Property(e => e.TerritoryID)
                .IsUnicode(false);

            modelBuilder.Entity<Territories>()
                .Property(e => e.TerritoryDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Territories>()
                .HasMany(e => e.EmployeeTerritories)
                .WithRequired(e => e.Territories)
                .WillCascadeOnDelete(false);
        }
    }
}
