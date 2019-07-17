using PosManager.Manager;
using PosManager.Views;
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

namespace PosManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ShopManager ShopManager;

        public MainWindow()
        {
            InitializeComponent();
            ShopManager = new ShopManager();

        }

        private void LoginButton(object sender, RoutedEventArgs e)
        {
           posList.Content = new POS(ShopManager);
        }

        //private void ShowProducts_Click(object sender, RoutedEventArgs e)
        //{
            //try
            //{
               // posList.Content = new ListProducts(ShopManager);
            //}
            //catch (NullReferenceException)
            //{

               // MessageBox.Show("Add products first");
            //}
        //}

        //private void ShowSales_Click(object sender, RoutedEventArgs e)
        //{
            //try
            //{
               // posList.Content = new ListSales(ShopManager);
           // }
            //catch (NullReferenceException)
            //{

                //MessageBox.Show("Add Sales first");
            //}
        //}

        //private void ShowSalesDetails_Click(object sender, RoutedEventArgs e)
        //{
            //try
            //{
               // posList.Content = new ListSalesDetails(ShopManager);
            //}
           // catch (NullReferenceException)
            //{

                //MessageBox.Show("Add Sales details first");
            //}
        //}

        //private void ShowCustomers_Click(object sender, RoutedEventArgs e)
        //{
            //try
            //{
               // posList.Content = new ListCustomer(ShopManager);
            //}
            //catch (NullReferenceException)
            //{

               // MessageBox.Show("Add Customer first");
            //}
        //}

        //private void ShowCategories_Click(object sender, RoutedEventArgs e)
        //{
            //try
            //{
               // posList.Content = new ListCategories(ShopManager);
            //}
            //catch (NullReferenceException)
            //{

                //MessageBox.Show("Add Categories first");
            //}
        //}

        //private void AddProduct_Click(object sender, RoutedEventArgs e)
        //{
        //posList.Content = new AddProduct(ShopManager);
        //}

        //private void AddSale_Click(object sender, RoutedEventArgs e)
        //{
            //posList.Content = new AddSales(ShopManager);
        //}

        //private void AddSalesDetails_Click(object sender, RoutedEventArgs e)
        //{
            //posList.Content = new AddSalesDetails(ShopManager);
        //}

        //private void AddCustomer_Click(object sender, RoutedEventArgs e)
        //{
            //posList.Content = new AddCustomer(ShopManager);
        //}

       // private void AddCategorie_Click(object sender, RoutedEventArgs e)
        //{
           // posList.Content = new AddCategorie(ShopManager);
        //}

        //private void ShowPos_Click(object sender, RoutedEventArgs e)
        //{
            //posList.Content = new POS(ShopManager);
        //}


        private void PosList_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
