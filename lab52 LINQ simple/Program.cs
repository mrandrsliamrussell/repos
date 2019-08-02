using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab52_LINQ_simple
{
    class Program
    {
        static List<Customer> customers;
        static void Main(string[] args)
        {
            using(var db = new NorthwindEntities())
            {
                Console.WriteLine("select customers and their orders\n\n");
                var output6 =
                      from customer in db.Customers
                      join order in db.Orders
                      on customer.CustomerID equals order.CustomerID
                      select new
                      {
                          Name = customer.ContactName,
                          orderDate = order.OrderDate,
                          orderid = order.OrderID
                      };

                output6.ToList().ForEach(c => Console.WriteLine($"{c.Name}..{c.orderid}..{c.orderDate}"));

            }

            Console.ReadKey();
        }
        static void PrintCustomers(List<Customer> customers)
        {
            Console.WriteLine("\n\n");
            foreach(var v in customers)
            {
                Console.WriteLine($"{v.CustomerID,-10},{v.ContactName},{v.City}");
            }
        }
    }
}
