using PosManager.Manager;
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

namespace PosManager.Views
{
    /// <summary>
    /// Interaction logic for POS.xaml
    /// </summary>
    public partial class POS : UserControl
    {
        ShopManager shopManager;
        public POS(Manager.ShopManager _shopManager)
        {
            InitializeComponent();
            shopManager = _shopManager;

        }
       
        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            PosLanding.Content = new AddProduct(shopManager);
        }

        private void AddSale_Click(object sender, RoutedEventArgs e)
        {
            PosLanding.Content = new AddSales(shopManager);
        }

        private void AddSalesDetails_Click(object sender, RoutedEventArgs e)
        {
            PosLanding.Content = new AddSalesDetails(shopManager);
        }

        private void AddCustomer_Click(object sender, RoutedEventArgs e)
        {
            PosLanding.Content = new AddCustomer(shopManager);
        }

        private void AddCategorie_Click(object sender, RoutedEventArgs e)
        {
            PosLanding.Content = new AddCategorie(shopManager);
        }

        //private void ShowPos_Click(object sender, RoutedEventArgs e)
        //{
        //posList.Content = new POS(ShopManager);
        //}
    }
}
