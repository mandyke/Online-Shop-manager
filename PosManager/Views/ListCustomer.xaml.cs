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
    /// Interaction logic for ListCustomer.xaml
    /// </summary>
    public partial class ListCustomer : UserControl
    {
        public ShopManager shopManager;
        public ListCustomer(Manager.ShopManager _shopManager)
        {
            try
            {
                InitializeComponent();

                shopManager = new ShopManager();

                shopManager = _shopManager;
                DataContext = this;

                shopManager.CustomersDatagrid = this.AddCustomerGridx;

                shopManager.BindCustomer();
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("Enter data in the Add Customer Field");
            }
            
        }

        public void btnEdit_Click(object sender, SelectedCellsChangedEventArgs e)
        {
            

        }

        public void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = AddCustomerGridx.SelectedItem;
            if (selectedItem != null)
            {
                if (MessageBox.Show("Are you sure you want to Delete this record", "Warning",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    AddCustomerGridx.Items.Remove(selectedItem);

                    // cast selectedItem as student
                    Customer objcus = selectedItem as Customer;
                    shopManager.DeleteCustomer(objcus);
                    MessageBox.Show("Record successfully deleted", "Response",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                }


            }
        }
    }
}
