using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DBData
{
    public partial class DBConnector : DbContext
    {
        public DBConnector()
            : base("name=DBConnector")
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
        public virtual DbSet<Alphabetical_list_of_products> Alphabetical_list_of_products { get; set; }
        public virtual DbSet<Category_Sales_for_1997> Category_Sales_for_1997 { get; set; }
        public virtual DbSet<Current_Product_List> Current_Product_List { get; set; }
        public virtual DbSet<Customer_and_Suppliers_by_City> Customer_and_Suppliers_by_City { get; set; }
        public virtual DbSet<Invoices> Invoices { get; set; }
        public virtual DbSet<Order_Details_Extended> Order_Details_Extended { get; set; }
        public virtual DbSet<Order_DetailsOrder_Details_ExtendedOrder_Details> Order_DetailsOrder_Details_ExtendedOrder_Details { get; set; }
        public virtual DbSet<Order_DetailsProducts_by_CategoryOrder_Details> Order_DetailsProducts_by_CategoryOrder_Details { get; set; }
        public virtual DbSet<Order_DetailsQuarterly_OrdersOrder_Details> Order_DetailsQuarterly_OrdersOrder_Details { get; set; }
        public virtual DbSet<Order_DetailsSales_by_CategoryOrder_Details> Order_DetailsSales_by_CategoryOrder_Details { get; set; }
        public virtual DbSet<Order_Subtotals> Order_Subtotals { get; set; }
        public virtual DbSet<Orders_Qry> Orders_Qry { get; set; }
        public virtual DbSet<Product_Sales_for_1997> Product_Sales_for_1997 { get; set; }
        public virtual DbSet<Products_Above_Average_Price> Products_Above_Average_Price { get; set; }
        public virtual DbSet<Products_by_Category> Products_by_Category { get; set; }
        public virtual DbSet<Quarterly_Orders> Quarterly_Orders { get; set; }
        public virtual DbSet<Sales_by_Category> Sales_by_Category { get; set; }
        public virtual DbSet<Sales_Totals_by_Amount> Sales_Totals_by_Amount { get; set; }
        public virtual DbSet<Summary_of_Sales_by_Quarter> Summary_of_Sales_by_Quarter { get; set; }
        public virtual DbSet<Summary_of_Sales_by_Year> Summary_of_Sales_by_Year { get; set; }

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

            modelBuilder.Entity<Alphabetical_list_of_products>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Alphabetical_list_of_products>()
                .Property(e => e.QuantityPerUnit)
                .IsUnicode(false);

            modelBuilder.Entity<Alphabetical_list_of_products>()
                .Property(e => e.UnitPrice)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Alphabetical_list_of_products>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<Category_Sales_for_1997>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<Current_Product_List>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer_and_Suppliers_by_City>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Customer_and_Suppliers_by_City>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer_and_Suppliers_by_City>()
                .Property(e => e.ContactName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer_and_Suppliers_by_City>()
                .Property(e => e.Relationship)
                .IsUnicode(false);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.ShipName)
                .IsUnicode(false);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.ShipAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.ShipCity)
                .IsUnicode(false);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.ShipRegion)
                .IsUnicode(false);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.ShipPostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.ShipCountry)
                .IsUnicode(false);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.CustomerID)
                .IsUnicode(false);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.Region)
                .IsUnicode(false);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.Salesperson)
                .IsUnicode(false);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.ShipperName)
                .IsUnicode(false);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.UnitPrice)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.Freight)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Order_Details_Extended>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Order_Details_Extended>()
                .Property(e => e.UnitPrice)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Order_DetailsOrder_Details_ExtendedOrder_Details>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Order_DetailsOrder_Details_ExtendedOrder_Details>()
                .Property(e => e.UnitPrice)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Order_DetailsProducts_by_CategoryOrder_Details>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<Order_DetailsProducts_by_CategoryOrder_Details>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Order_DetailsProducts_by_CategoryOrder_Details>()
                .Property(e => e.QuantityPerUnit)
                .IsUnicode(false);

            modelBuilder.Entity<Order_DetailsQuarterly_OrdersOrder_Details>()
                .Property(e => e.CustomerID)
                .IsUnicode(false);

            modelBuilder.Entity<Order_DetailsQuarterly_OrdersOrder_Details>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<Order_DetailsQuarterly_OrdersOrder_Details>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Order_DetailsQuarterly_OrdersOrder_Details>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Order_DetailsSales_by_CategoryOrder_Details>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<Order_DetailsSales_by_CategoryOrder_Details>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Orders_Qry>()
                .Property(e => e.CustomerID)
                .IsUnicode(false);

            modelBuilder.Entity<Orders_Qry>()
                .Property(e => e.Freight)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Orders_Qry>()
                .Property(e => e.ShipName)
                .IsUnicode(false);

            modelBuilder.Entity<Orders_Qry>()
                .Property(e => e.ShipAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Orders_Qry>()
                .Property(e => e.ShipCity)
                .IsUnicode(false);

            modelBuilder.Entity<Orders_Qry>()
                .Property(e => e.ShipRegion)
                .IsUnicode(false);

            modelBuilder.Entity<Orders_Qry>()
                .Property(e => e.ShipPostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Orders_Qry>()
                .Property(e => e.ShipCountry)
                .IsUnicode(false);

            modelBuilder.Entity<Orders_Qry>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<Orders_Qry>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Orders_Qry>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Orders_Qry>()
                .Property(e => e.Region)
                .IsUnicode(false);

            modelBuilder.Entity<Orders_Qry>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Orders_Qry>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Product_Sales_for_1997>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<Product_Sales_for_1997>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Products_Above_Average_Price>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Products_Above_Average_Price>()
                .Property(e => e.UnitPrice)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Products_by_Category>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<Products_by_Category>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Products_by_Category>()
                .Property(e => e.QuantityPerUnit)
                .IsUnicode(false);

            modelBuilder.Entity<Quarterly_Orders>()
                .Property(e => e.CustomerID)
                .IsUnicode(false);

            modelBuilder.Entity<Quarterly_Orders>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<Quarterly_Orders>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Quarterly_Orders>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Sales_by_Category>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<Sales_by_Category>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Sales_Totals_by_Amount>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);
        }
    }
}
