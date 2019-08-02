using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Xml.Linq;

using System.IO;
using System.Xml.Serialization;

namespace lab69_XML_from_northwind
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new Northwind())
            {
                var productList = db.Products.ToList();
                foreach (var p in productList)
                {
                   
                    var XMLproduct = new XElement("Product",

                   new XElement("ProductID", p.ProductName),
                   new XElement("ProductName", p.ProductID),
                   new XElement("CategoryID", p.CategoryID),
                   new XElement("UnitPrice", p.UnitPrice)

                   );
                 //   Console.WriteLine(XMLproduct);
                }
               

                    var XMLProducts = new XElement("Products",
                        from pl in productList.Take(5)
                        select new XElement("Product" ,
                       new XElement("ProductID", pl.ProductName),
                        new XElement("ProductName", pl.ProductID),
                        new XElement("CategoryID", pl.CategoryID),
                         new XElement("UnitPrice", pl.UnitPrice)
                        ));
                Console.WriteLine(XMLProducts);
                XMLProducts.Save("products.xml");
                // productList.ForEach(p => Console.WriteLine($"{p.ProductName}  {p.ProductID}  {p.CategoryID}  {p.UnitPrice}"));

                var productsFromXml = new Product();
                using(var reader = new StreamReader("products.xml"))
                {
                    var serialiser = new XmlSerializer(typeof(Products));

                     productsFromXml = (Product)serialiser.Deserialize(reader);
                }
                 
            }
            
        }
    }
    [XmlRoot("Products")]
    public class Products
    {
        [XmlElement("Product")]
        public List<Product> ProductList { get; set; }
    }
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        public Category()
        {
            this.Products = new List<Product>();
        }
    }



    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int? CategoryID { get; set; }
       // public virtual Category Category { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; } = 0;
        public short? UnitsInStock { get; set; } = 0;
        public short? UnitsOnOrder { get; set; } = 0;
        public short? ReorderLevel { get; set; } = 0;
        public bool Discontinued { get; set; } = false;
    }




    public class Northwind : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;" +
                   "Initial Catalog=Northwind;" + "Integrated Security = true;" +
                   "MultipleActiveResultSets=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .Property(c => c.CategoryName)
                .IsRequired()
                .HasMaxLength(15);

            // define a one-to-many relationship
         //   modelBuilder.Entity<Category>()
         //       .HasMany(c => c.Products)
          //      .WithOne(p => p.Category);

            modelBuilder.Entity<Product>()
                .Property(c => c.ProductName)
                .IsRequired()
                .HasMaxLength(40);

          //  modelBuilder.Entity<Product>()
             //   .HasOne(p => p.Category)
             //   .WithMany(c => c.Products);

        }
    }
}
