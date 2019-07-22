using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snap_lab_4_sql_test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindEntities())
            {
                var customers = db.Customers.ToList();

                foreach (var c in customers) {

                    if (c.City == "London" || c.City == "Paris")
                    {
                        Console.WriteLine($"{c.ContactName} {c.City}");
                    }

                }

                var products = db.Products.ToList();

                foreach (var p in products)
                {
                    if (p.QuantityPerUnit.Contains("bottle"))
                    {
                        Console.WriteLine($"{p.ProductName} {p.QuantityPerUnit}");
                    }
                }



                var bottles =
                 from p in products
                 join supplier in db.Suppliers
                 on p.SupplierID equals supplier.SupplierID
                 where p.QuantityPerUnit.Contains("bottle")
                 select p;

                foreach (var b in bottles.ToList())
                {
                    Console.WriteLine($"{b.ProductName} {b.Supplier.CompanyName} {b.Supplier.Country}");
                }

                var noOfProducts =
                    from p in products
                    join category in db.Categories
                    on p.CategoryID equals category.CategoryID
                    group p by p.CategoryID into categories
                    orderby categories.Key
                    select new
                    {
                        Name = categories.Key,
                        count = categories.Count(),
                        

                    };

               foreach(var p in noOfProducts)
                {
                    Console.WriteLine($"{p.Name.ToString()}{p.count}");
                }


                var ukemployees =
                     from e in db.Employees
                     where e.City == "London"
                     select e;
                ukemployees.ToList().ForEach(c => Console.WriteLine($"{c.TitleOfCourtesy}, {c.FirstName}, {c.LastName},{c.City}"));

                var ordersOver100 =
                    from o in db.Orders
                    where o.Freight > 100 && (o.ShipCountry == "USA" || o.ShipCountry =="UK")
                    select o;
                Console.WriteLine(ordersOver100.ToList().Count());



                     



            }

            Console.ReadLine();
        }
    }
}
