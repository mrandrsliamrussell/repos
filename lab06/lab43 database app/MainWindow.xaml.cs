using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab43_database_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customer> customers;
        Customer customer;
        int listID;
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }
 //       public static NorthwindEntities db;
        void Initialise()
        {
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();
               
            }
            //Customers.DisplayMemberPath = "ContactName";
            Customers.ItemsSource = customers;
        }

        private void Button1Click(object sender, RoutedEventArgs e)
        {
            if ((string)button01.Content == "Clear")
            {

                IDTextbox.Text = "";
                NameTextbox.Text = "";
                CompanyTextbox.Text = "";
                CityTextbox.Text = "";
                CountryTextbox.Text = "";
                button01.Content = "Add";
                
            }
            else if((string)button01.Content == "Add")
            {
                
                Customer newCustomer = new Customer();

                newCustomer.CustomerID = IDTextbox.Text;
                newCustomer.ContactName = NameTextbox.Text;
                newCustomer.CompanyName = CompanyTextbox.Text;
                newCustomer.City = CityTextbox.Text;
                newCustomer.Country = CountryTextbox.Text;
                Customers.ItemsSource = null;
                customers.Add(newCustomer);
                Customers.ItemsSource = customers;
                using (var db = new NorthwindEntities())
                {
                   // db.Customers.Add(newCustomer);
                    var customerToEdit = db.Customers.Where(c => c.CustomerID == newCustomer.CustomerID).FirstOrDefault();
                    customerToEdit.CustomerID = IDTextbox.Text; ;
                    customerToEdit.ContactName = NameTextbox.Text;
                    customerToEdit.City = CityTextbox.Text;
                    customerToEdit.Country = CountryTextbox.Text;
                    customerToEdit.CompanyName = CompanyTextbox.Text;
                    db.SaveChanges();
                }
                    

                button01.Content = "Clear";
            }
            

            }

            private void Button2Click(object sender, RoutedEventArgs e)
            {

            if ((string)button02.Content == "Edit")
            {

                
                button02.Content = "Save";

            }
            else if ((string)button02.Content == "Save")
            {

                Customer newCustomer = new Customer();

               

                Customers.ItemsSource = null;
                customers.RemoveAt(listID);
               
                customers.Insert(listID, newCustomer);
                Customers.ItemsSource = customers;


                using (var db = new NorthwindEntities())
                {

                    var customerToEdit = db.Customers.Where(c => c.CustomerID == newCustomer.CustomerID).FirstOrDefault();
                  customerToEdit.CustomerID = IDTextbox.Text;
                  customerToEdit.ContactName = NameTextbox.Text;
                  customerToEdit.CompanyName = CompanyTextbox.Text;
                  customerToEdit.City = CityTextbox.Text;
                  customerToEdit.Country = CountryTextbox.Text;
                    db.SaveChanges();
                }

                button02.Content = "Edit";
            }
        }

            private void Button3Click(object sender, RoutedEventArgs e)
            {
             if ((string)button03.Content == "Delete")
            {

                Customer newCustomer = new Customer();

           
                Customers.ItemsSource = null;
                customers.RemoveAt(listID);
                
                Customers.ItemsSource = customers;
                using (var db = new NorthwindEntities())
                {

                    var customerToEdit = db.Customers.Where(c => c.CustomerID == newCustomer.CustomerID).FirstOrDefault();
                 

                    db.SaveChanges();
                }

                
            }
        }

            private void Customers_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                
                customer = (Customer)Customers.SelectedItem;
            try
            {
                log.Items.Insert(0, DateTime.Now);
                log.Items.Insert(0, "Customer selected");
                log.Items.Insert(0, $"{customer.CustomerID,-7}, {customer.ContactName}, From {customer.City} ");
                IDTextbox.Text = customer.CustomerID;
                NameTextbox.Text = customer.ContactName;
                CompanyTextbox.Text = customer.CompanyName;
                CityTextbox.Text = customer.City;
                CountryTextbox.Text = customer.Country;
                listID = Customers.SelectedIndex;
            }
            catch { }
              
              
            }
        }
    } 
