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
    /// Interaction logic for ListSales.xaml
    /// </summary>
    public partial class ListSales : UserControl
    {
        public ShopManager shopManager;
        

        public ListSales(Manager.ShopManager _shopManager)
        {
            InitializeComponent();
            shopManager = _shopManager;
            DataContext = this;
            shopManager.SaleDatagrid = this.AddSalesGrid;
            shopManager.BindSales();

            InitializeComponent();
            shopManager = _shopManager;
            DataContext = this;
            shopManager.SaleDatagrid = this.AddSalesGrid2;
            shopManager.BindSales();
        }



        private void AddSalesGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Sales details = AddSalesGrid2.SelectedItem as Sales;
                customerName.Text = details.CustomerName;
                //productName.Text = details.Product;
                //quantity.Text = details.Quantity.ToString();
               // grandTotal.Text = details.GrandTotal.ToString();
               // amount.Text = details.Amount.ToString();
                balance.Text = details.Balance.ToString();

                shopManager.AddSale(details);
                shopManager.BindSales();

            }
            
            catch (NullReferenceException)
            {

               
            }
            
        }
    }
}
