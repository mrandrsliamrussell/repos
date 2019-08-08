using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab74_aspcore_website.Models;

namespace lab74_aspcore_website.Pages
{
    public class northwindModel : PageModel
    {
       public List<Customer> customers = new List<Customer>();
        public void OnGet()
        {
            using(var db = new Northwind())
            {
                customers = db.Customers.ToList();
            }
        }
    }
}