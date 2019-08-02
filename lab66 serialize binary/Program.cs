using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace lab66_serialize_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            var c01 = new Customer(01, "fred", "1 cool dude street", "bf425093e");
            var c02 = new Customer(02, "jim", "7 nice dude street", "hu422191h");
            var c03 = new Customer(03, "alan", "54 mad dude street", "rf4356qe");

            var customers = new List<Customer>() { c01, c02, c03 };

            //performs the serialization
            var binaryformatter = new BinaryFormatter();

            //Stream binary data to file in this case, could be web or ram
            using(var binarystream = new FileStream("data.bin", FileMode.Create,FileAccess.Write, FileShare.None))
            {

                //write data to file
                binaryformatter.Serialize(binarystream, customers);
               


            }
            Console.WriteLine(File.ReadAllText("data.bin"));

            var customersfrombinary = new List<Customer>();
            using (var reader = File.OpenRead("data.bin"))
            {

                  customersfrombinary = binaryformatter.Deserialize(reader) as List<Customer>;
            }

            foreach(var c in customersfrombinary)
            {
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
