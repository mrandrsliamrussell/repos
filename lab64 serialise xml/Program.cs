using System;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Soap;

namespace lab64_serialise_xml
{
    class Program
    {
        static void Main(string[] args)
        {
            var c01 = new Customer(01,"fred", "1 cool dude street","bf425093e");

            //xml serialise into a filestream
            var formatter = new SoapFormatter();
            using(var filestream = new FileStream("data.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                //send data to filestream
                formatter.Serialize(filestream, c01);
                
            }
            Console.WriteLine(File.ReadAllText("data.xml"));

            //imagine were on another computer: can we reconstruct an instance?

            Customer desCus;
            using (var streamreader = File.OpenRead("data.xml"))
            {
                // desearialise back into instance of class
                desCus = formatter.Deserialize(streamreader) as Customer;
            }
            Console.WriteLine($"reconstructed customer: {desCus.customerName} {desCus.customerID} {desCus.address} ");

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

        public Customer(int customerid, string  name, string address, string NiNo)
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
