using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace lab51_database_stuff
{
    class Program
    {
       static List<Customer> customers = new List<Customer>();
      
        static void Main(string[] args)
        {



            var newCustomer = new Customer() {

                CustomerID = "WWWWW",
                ContactName = "bob",
                City = "the moon",
                CompanyName = "thicc company"
                
                

            };

            using (var db = new NorthwindEntities())
            {
               
                
                db.Customers.Add(newCustomer);
                customers = db.Customers.ToList();
                db.SaveChanges();
            }


            printstuff();


            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
       

            using(var db = new NorthwindEntities())
            {
                var newdb = db.Customers.Find("WWWWW");
                newdb.City = "AAAAAAA";
                db.SaveChanges();
                customers = null;
                customers = db.Customers.ToList();
              
            }


            printstuff();


            using (var db = new NorthwindEntities())
            {
                var newdb = db.Customers.Find("WWWWW");
                db.Customers.Remove(newdb);
                db.SaveChanges();
                customers = null;
                customers = db.Customers.ToList();

            }


            printstuff();
            Console.ReadLine();

        }

       public static void printstuff()
        {


            Console.WriteLine("\n\n\n\n");
            foreach (var v in customers)
            {
                
                Console.WriteLine($"{v.CustomerID},{ v.Address}, {v.City}, {v.ContactName}, {v.ContactTitle}, {v.CompanyName}");
            }
            
        }

    }
}
