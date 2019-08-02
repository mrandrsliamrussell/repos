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

namespace lab47_business_application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Customer> customerList = new List<Customer>();
        public List<Product> productList = new List<Product>();
        public List<Shipper> shipperList = new List<Shipper>();

        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }
        public void Initialise()
        {
            using (var db = new NorthwindEntities())
            {
                customerList = db.Customers.ToList();
                productList = db.Products.ToList();
                shipperList = db.Shippers.ToList();

            }

            ListViewCustomers.ItemsSource = customerList;
            CustomerListbox.ItemsSource = customerList;
            ProductListbox.ItemsSource = productList;
            SupplierListbox.ItemsSource = shipperList;
            CustomerAddressText.IsEnabled = false;
            CustomerNameText.IsEnabled = false;
            CustomerIDText.IsEnabled = false;
            CustomerCityText.IsEnabled = false;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if((string)AddButton.Content == "Add")
            {
                CustomerAddressText.IsEnabled = true;
                CustomerNameText.IsEnabled = true;
                CustomerIDText.IsEnabled = true;
                CustomerCityText.IsEnabled = true;
                

               


                AddButton.Content = "Save";
            }
            else if((string)AddButton.Content == "Save")
            {
                Customer newCustomer = new Customer();
                newCustomer.CustomerID = CustomerIDText.Text;
                newCustomer.ContactName = CustomerNameText.Text;
                newCustomer.Address = CustomerAddressText.Text;
                newCustomer.City = CustomerCityText.Text;
                newCustomer.CompanyName = "company";
                CustomerListbox.ItemsSource = null;
                customerList.Add(newCustomer);
                CustomerListbox.ItemsSource = customerList;
                using (var db = new NorthwindEntities())
                {
                    
                 
                    db.Customers.Add(newCustomer);
                   
                    
                    db.SaveChanges();
                }


                CustomerAddressText.IsEnabled = false;
                CustomerNameText.IsEnabled = false;
                CustomerIDText.IsEnabled = false;
                CustomerCityText.IsEnabled = false;

                AddButton.Content = "Add";
            }
        }

        private void ListViewCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
    }
}
