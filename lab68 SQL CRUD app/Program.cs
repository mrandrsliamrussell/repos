using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Net;
using Newtonsoft.Json;

namespace lab68_SQL_CRUD_app
{
    class Program
    {
        static void Main(string[] args)
        {
            AddCustomerToDatabase(GenerateID().ToString(), "Mr Brian Bedungdy", "Brian's Bedungdies", "Londoooooooon");
            // UpdateCustomer("AAAAA", "Mr Jim Sterling", "Jims Jimmys", "London");
            // DeletThis("AAAAA");
            GetCity();
            void GetCity()
            {
                Uri MyUri = new Uri("https://next.json-generator.com/api/json/get/V1g-tRsGP");

                var downloadMyURI = new WebClient { Proxy = null };
                downloadMyURI.DownloadFile(MyUri, "City.json");
               
                var City = JsonConvert.DeserializeObject(File.ReadAllText("City.json"));
                

                //var object01 = JsonConvert.DeserializeObject;
                Console.WriteLine(City.ToString());

            }


            string GenerateID()
            {

                Random rand = new Random();
                char[] ID = new char[5];
                string output;
                for (int i = 0; i < ID.Length; i++)
                {
                    ID[i] = Convert.ToChar(rand.Next(65, 90));
                }
                output = new string(ID);
                Console.WriteLine(output);

                return output;
            }

            void ReadDataWriteToFile()
            {
                List<Customer> customerList = new List<Customer>();
                using (var connection = new SqlConnection(@"Data Source = localhost, 1433; User ID = SA; Password = Passw0rd2018; Connect Timeout = 30; Initial Catalog=Northwind; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
                {
                    connection.Open();

                    Console.WriteLine(connection.State);
                    using (var command = new SqlCommand("select * from Customers", connection))
                    {

                        var sqlreader = command.ExecuteReader();
                        while (sqlreader.Read())
                        {
                            Customer newCustomer = new Customer(sqlreader["CustomerID"].ToString(), sqlreader["ContactName"].ToString(), sqlreader["CompanyName"].ToString(), sqlreader["City"].ToString());
                            customerList.Add(newCustomer);
                        }
                    }

                }

                customerList.ForEach(c => Console.WriteLine($"{c.CustomerID,-10} {c.Contact_Name,-20} {c.CompanyName,-20} {c.City,-20}"));
                customerList.ForEach(c => File.AppendAllText("Customers.csv", $"{c.CustomerID}, {c.Contact_Name}, {c.CompanyName} ,{c.City}\n"));
            }

            void AddCustomerToDatabase(string ID, string ContactName, string CompanyName, string City)
            {

                using (var connection = new SqlConnection(@"Data Source = localhost, 1433; User ID = SA; Password = Passw0rd2018; Connect Timeout = 30; Initial Catalog=Northwind; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
                {
                    connection.Open();
                    Console.WriteLine(connection.State);
                    var inscommand = new SqlCommand("INSERT INTO Customers (CustomerID, ContactName, CompanyName, City) Values(@CustomerID, @ContactName, @CompanyName, @City)", connection);

                    inscommand.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                    inscommand.Parameters.Add("@ContactName", SqlDbType.VarChar);
                    inscommand.Parameters.Add("@CompanyName", SqlDbType.VarChar);
                    inscommand.Parameters.Add("@City", SqlDbType.VarChar);

                    inscommand.Parameters["@CustomerID"].Value = ID;
                    inscommand.Parameters["@ContactName"].Value = ContactName;
                    inscommand.Parameters["@CompanyName"].Value = CompanyName;
                    inscommand.Parameters["@City"].Value = City;


                    var sqlreader = inscommand.ExecuteNonQuery();



                }
                ReadDataWriteToFile();
            }

            void UpdateCustomer(string ID, string ContactName, string CompanyName, string City)
            {
                using (var connection = new SqlConnection(@"Data Source = localhost, 1433; User ID = SA; Password = Passw0rd2018; Connect Timeout = 30; Initial Catalog=Northwind; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
                {
                    SqlParameter[] p = new SqlParameter[4];
                    p[0] = new SqlParameter("@CustomerID", ID);
                    p[1] = new SqlParameter("@ContactName", ContactName);
                    p[2] = new SqlParameter("@CompanyName", CompanyName);
                    p[3] = new SqlParameter("@City", City);
                    connection.Open();
                    Console.WriteLine(connection.State);
                    using (var command = new SqlCommand("UPDATE [Customers] SET  ContactName = @ContactName, CompanyName = @CompanyName, City = @City WHERE CustomerID = @CustomerID", connection))
                    {
                        if (p != null)
                        {
                            command.Parameters.AddRange(p);
                        }
                        command.ExecuteNonQuery();
                        connection.Close();
                        command.Parameters.Clear();

                    }
                    /* other way to do it
                    using(var sqlupdate = new SqlCommand("UpdateCustomer", connection))
                    {
                        sqlupdate.CommandType = CommandType.StoredProcedure;
                        //add values
                        sqlupdate.Parameters.AddWithValue("CustomerID", ID);
                        sqlupdate.Parameters.AddWithValue("City", City);
                    }*/
                }
                ReadDataWriteToFile();

            }

            void DeletThis(string CustomerID)
            {
                using (var connection = new SqlConnection(@"Data Source = localhost, 1433; User ID = SA; Password = Passw0rd2018; Connect Timeout = 30; Initial Catalog=Northwind; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
                {

                    connection.Open();
                    var command = new SqlCommand("DELETE FROM Customers WHERE CustomerID = @CustomerID", connection);
                    command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    command.ExecuteNonQuery();
                    connection.Close();


                }
                ReadDataWriteToFile();
            }

        }

    }

    class Customer
    {
        public string CustomerID { get; set; }
        public string Contact_Name { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }

        public Customer(string customerID, string contact_Name, string companyName, string city)
        {
            this.CustomerID = customerID;
            this.Contact_Name = contact_Name;
            this.CompanyName = companyName;
            this.City = city;
        }


    }
}
