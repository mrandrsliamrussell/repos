using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql_with_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers;
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();
            }
            foreach(var customer in customers)
            {
                Console.WriteLine($"{customer.CustomerID.ToString(),-10}{customer.CompanyName, -30} {customer.ContactName.ToString(), -30}");
            }
            Console.ReadLine();
        }
    }
}
