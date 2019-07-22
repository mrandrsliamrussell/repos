using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab53_LINQ
{
    class Program
    {
        static string[] cities;
        static void Main(string[] args)
        {
            using(var db = new NorthwindEntities())
            {
                var output =
                from customer in db.Customers
                select customer;
                int i = 0;
                foreach(var v in output)
                {
                    i++;
                }
                Console.WriteLine(i);

            }
            using (var db = new NorthwindEntities())
            {
                var output2 =
                from products in db.Products
                select products;
                int i = 0;
                foreach (var v in output2)
                {
                    i++;
                }
                Console.WriteLine(i);

            }
            using (var db = new NorthwindEntities())
            {
                var output3 =
                from order in db.Orders
                select order;
                int i = 0;
                foreach (var v in output3)
                {
                    i++;
                }
                Console.WriteLine(i);

            }
            using (var db = new NorthwindEntities())
            {
                var output4 =
                from order in db.Order_Details
                select order;
                decimal i = 0; int j = 0;
                foreach (var v in output4)
                {
                    j++;
                    i += (v.UnitPrice * v.Quantity) * (decimal)(1 - v.Discount);
                }

                i /= j;
                Console.WriteLine(i);
                
            }
            using (var db = new NorthwindEntities())
            {
                var categories = db.Categories.ToList();
                var products = db.Products.ToList();
               
                foreach (var c in categories)
                {
                    Console.WriteLine($"{c.CategoryID}) {c.CategoryName} has { c.Products.Count} products");
                    Console.WriteLine("=============products==============");
                    foreach (var p in c.Products)
                    {
                        Console.WriteLine($"\t{p.ProductID} is {p.ProductName}");
                    }
                }
               

            }
            using (var db = new NorthwindEntities())
            {
                var customers = db.Customers.ToList();
                var orders = db.Orders.ToList();               
                foreach(var c in customers)
                {
                    int j = 0;
                    foreach (var o in orders)
                    {
                        if (c.CustomerID == o.CustomerID)
                        {
                            j++;
                        }                          
                    }
                    Console.WriteLine($"{c.CustomerID} {c.ContactName} has {j} orders");
                }


                foreach (var v in customers) { Console.WriteLine(v.ContactName); }
                customers.ForEach(c => Console.WriteLine(  c.ContactName));

                //creating a sub array from a larger list
                //for example create an array of cities from our list of countries

                cities = db.Customers.Select(customer => customer.City).Distinct().OrderBy(city => city).ToArray();

                //traditional
                foreach (var city in cities) { Console.WriteLine(city); }
                //lambda
                Array.ForEach(cities, city => Console.WriteLine(city));

                var supplier = db.Suppliers.ToList();

                foreach (var s in supplier) { Console.WriteLine(s.CompanyName); }
                supplier.ForEach(s => Console.WriteLine(s.CompanyName));

                int i = 0;
                supplier.ForEach(s => i++);
                Console.WriteLine( i);

                var od = db.Order_Details.ToList();
                var supp = db.Order_Details.Select(o => o.Quantity * o.UnitPrice).Min();
                var supp2 = db.Order_Details.Select(o => o.Quantity * o.UnitPrice).Max();
                var supp3 = db.Order_Details.Select(o => o.Quantity * o.UnitPrice).Average();

                Console.WriteLine($"min{supp}  max{supp2}  avg{supp3}");

                //chaining where

                var x = db.Orders.Where(o => o.ShipCountry != "USA").Where(p => p.ShipRegion != "Southern");
                Console.WriteLine(x.Count());

                var array1 = new string[] { "one", "two", "three", null, null, "five" };
                var array2 = array1.Where(item => item != null);
                var list1 = new List<string>();
                foreach(var g in array1)
                {
                    list1.Add(g);
                }
                var array3 = list1.ToArray();

                Array.ForEach(array3, array => Console.WriteLine(array));

                var y = db.Customers.Where(c => c.Region != null).ToList();
                y.ForEach(n => Console.WriteLine($"{n.Region} {n.ContactName} {y.Count()}"));

                var z = db.Customers.OrderBy(c => c.Region).ThenBy(d => d.CustomerID).ToList();
                Console.WriteLine("\n\n");
                z.ForEach(n => Console.WriteLine($"{n.Region} {n.CustomerID}"));
                var z1 = db.Customers.OrderBy(c => c.Region).ThenBy(d => d.CustomerID).Skip(30).ToList();
                Console.WriteLine("\n\n");
                z1.ForEach(n => Console.WriteLine($"{n.Region} {n.CustomerID}"));
                var z2 = db.Customers.OrderBy(c => c.Region).ThenBy(d => d.CustomerID).Take(5).ToList();
                Console.WriteLine("\n\n");
                z2.ForEach(n => Console.WriteLine($"{n.Region} {n.CustomerID}"));

          
                for(int r = 0; r < db.Customers.Count(); r += 10)
                {
                   var z3 = db.Customers.OrderBy(f => f.CompanyName).Skip(r).Take(10).ToList();
                    z3.ForEach(n => Console.WriteLine($"{n.CustomerID} {n.CompanyName}"));
                    Console.WriteLine("\n");
                    System.Threading.Thread.Sleep(1000);
                   
                }





            }

       
            Console.ReadLine();
        }
    }
}
