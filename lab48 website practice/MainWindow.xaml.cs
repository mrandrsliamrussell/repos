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

namespace lab48_website_practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       static List<Customer> CustomerList = new List<Customer>();
       static List<Customer> RetCustomerList = new List<Customer>();

       static List<Supplier> SupplierList = new List<Supplier>();
       static List<Supplier> RetSupplierList = new List<Supplier>();

       static List<Product> ProductList = new List<Product>();
       static List<Product> RetProductList = new List<Product>();
        static int windowSelection;
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }
        public void Initialise()
        {
           

            using(var db = new northwindEntities())
            {
                CustomerList = db.Customers.ToList();
                SupplierList = db.Suppliers.ToList();
                ProductList = db.Products.ToList();
            }
            ListViewCustomers.ItemsSource = CustomerList;
            ListViewSuppliers.ItemsSource = SupplierList;
            ListViewProducts.ItemsSource = ProductList;


        }
       void customerTabClick(object sender, SelectionChangedEventArgs e)
        {
            
           
        }

        private void CustomersSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void SuppliersSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void ProductsSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            refreshSearch();

        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            refreshSearch();
        }
        void refreshSearch()
        {
            using (var db = new northwindEntities())
            {
                if (option1.IsChecked == true)
                {
                    RetProductList = db.Products.Where(p => p.ProductName.Contains(textSearch.Text)).ToList();
                    RetCustomerList = db.Customers.Where(p => p.CustomerID.Contains(textSearch.Text)).ToList();
                    RetSupplierList = db.Suppliers.Where(p => p.CompanyName.Contains(textSearch.Text)).ToList();
                }
                else if (option2.IsChecked == true)
                {
                    RetProductList = db.Products.Where(p => p.ProductName.Contains(textSearch.Text)).ToList();
                    RetCustomerList = db.Customers.Where(p => p.ContactName.Contains(textSearch.Text)).ToList();
                    RetSupplierList = db.Suppliers.Where(p => p.Country.Contains(textSearch.Text)).ToList();
                }
                else if (option3.IsChecked == true)
                {
                    RetProductList = db.Products.Where(p => p.ProductName.Contains(textSearch.Text)).ToList();
                    RetCustomerList = db.Customers.Where(p => p.CompanyName.Contains(textSearch.Text)).ToList();
                    RetSupplierList = db.Suppliers.Where(p => p.Region.Contains(textSearch.Text)).ToList();
                }


            }
            ListViewCustomers.ItemsSource = null;
            ListViewCustomers.ItemsSource = RetCustomerList;

            ListViewSuppliers.ItemsSource = null;
            ListViewSuppliers.ItemsSource = RetSupplierList;

            ListViewProducts.ItemsSource = null;
            ListViewProducts.ItemsSource = RetProductList;
        }
    }
}
