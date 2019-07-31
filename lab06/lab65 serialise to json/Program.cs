using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;

namespace lab65_serialise_to_json
{
    class Program
    {
        static void Main(string[] args)
        {
            var c01 = new Customer(01, "fred", "1 cool dude street", "bf425093e");
            var c02 = new Customer(02, "jim", "7 nice dude street", "hu422191h");
            var c03 = new Customer(03, "alan", "54 mad dude street", "rf4356qe");

            var customers = new List<Customer>() { c01, c02, c03 };

            var jsoninstance01 = JsonConvert.SerializeObject(c01);
            var jsoninstance02 = JsonConvert.SerializeObject(c02);
            var jsoninstance03 = JsonConvert.SerializeObject(c03);

            File.WriteAllText("jsonfile.json",jsoninstance01);

            Console.WriteLine(File.ReadAllText("jsonfile.json"));


            var customerlistasJSOn = JsonConvert.SerializeObject(customers);
            File.WriteAllText("customers.json", customerlistasJSOn);
            Console.WriteLine(customerlistasJSOn);

            Uri philsLink = new Uri("https://raw.githubusercontent.com/philanderson888/data/master/customers.json");


            var downloadPhilsFile = new WebClient { Proxy = null };

            downloadPhilsFile.DownloadFile(@"https://raw.githubusercontent.com/philanderson888/data/master/customers.json", "customers.json");

            var customerfromjson = JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText("customers.json"));


            Console.WriteLine("\n\n");

            foreach(var c in customerfromjson){

                Console.WriteLine($"{c.customerID} {c.customerName} {c.address}");

            }

        }
    }
    [Serializable]
    class Customer
    {
        public int customerID { get; set; }
        public string customerName { get; set; }
        public string address { get; set; }
        [NonSerialized]
        private string NINO;

        public Customer(int customerid, string name, string address, string NiNo)
        {
            this.NINO = NiNo;
            this.customerID = customerid;
            this.customerName = name;
            this.address = address;
        }
        public string GetNino()
        {
            return NINO;
        }
    }
}
