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
    /// Interaction logic for ListProducts.xaml
    /// </summary>
    public partial class ListProducts : UserControl
    {
        public ShopManager shopManager;

        public ListProducts(Manager.ShopManager _shopManager)
        {
            InitializeComponent();
            shopManager = _shopManager;

            DataContext = this;

            shopManager.ProductDatagrid = this.AddProductGrid;

            shopManager.BindProducts();
        }

        private void AddProductGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void btnEdit_Click(object sender, SelectedCellsChangedEventArgs e)
        {

        }

        public void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = AddProductGrid.SelectedItem;
            if(selectedItem != null)
            if(MessageBox.Show("Are you sure you want to Delete this record", "Warning",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                AddProductGrid.Items.Remove(selectedItem);

                    // cast selectedItem as student
                    Products objprod = selectedItem as Products;
                    shopManager.DeleteProduct(objprod);
                    MessageBox.Show("Record successfully deleted", "Response",
                        MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }
    }
}
