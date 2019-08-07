using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Net;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Snap_Lab_20_sql_from_xml
{
    class Program
    {
        static void Main(string[] args)
        {
            
            XMLFormatter1();
            XMLFormatter2();
            XMLFormatter3();
            
           
        }

        static void XMLFormatter1()
        {
            using (var db = new NorthwindEntities())
            {

                var customerList = db.Customers.ToList();

                var XMLCustomer = new XElement("Customers",

                      from c in customerList
                      where c.City == "Paris" || c.City == "London"
                      select new  XElement("Customer",
                              new XElement("CustomerID", c.CustomerID),
                              new XElement("CompanyName", c.CompanyName),
                              new XElement("Address", c.CompanyName),
                              new XElement("City", c.City)

                              ));
               
                    Console.WriteLine(XMLCustomer);
                
                XMLCustomer.Save("Customer.xml");
            }



        }
        static void XMLFormatter2()
        {
            using (var db = new NorthwindEntities())
            {

                var productList = db.Products.ToList();

                var XMLProduct = new XElement("Products",

                      from p in productList
                      where p.QuantityPerUnit.Contains("bottle")
                      select new XElement("Product",
                              new XElement("ProductID", p.ProductID),
                              new XElement("ProductName", p.ProductName),
                              new XElement("QuantityPerUnit", p.QuantityPerUnit),
                              new XElement("UnitPrice", p.UnitPrice)

                              ));
                
                    Console.WriteLine(XMLProduct);
                
                XMLProduct.Save("products.xml");
            }

            

        }
        static void XMLFormatter3()
        {
            using (var db = new NorthwindEntities())
            {

                var productList = db.Products.ToList();
                var supplierlist = db.Suppliers.ToList();
                var XMLProduct = new XElement("Products",

                      from p in productList
                      join supplier in db.Suppliers
                      on p.SupplierID equals supplier.SupplierID
                      where p.QuantityPerUnit.Contains("bottle")
                      select new XElement("Product",
                              new XElement("ProductID", p.ProductID),
                              new XElement("ProductName", p.ProductName),
                              new XElement("QuantityPerUnit", p.QuantityPerUnit),
                              new XElement("UnitPrice", p.UnitPrice),
                              new XElement("SupplierName", supplier.CompanyName),
                              new XElement("CountryOfOrigin", supplier.Country)

                              ));

                Console.WriteLine(XMLProduct);

                XMLProduct.Save("products2.xml");
            }

            Console.ReadLine();

        }
    }
}
