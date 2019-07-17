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
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : UserControl
    {
        int CustId = 0;
        public ShopManager shopManager;
        public AddCustomer(Manager.ShopManager _shopManager)
        {
            InitializeComponent();
            shopManager = _shopManager;

            DataContext = this;

            shopManager.CustomersDatagrid = this.AddCustomerGrid;
            shopManager.BindCustomer();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            CustId += 1;
            try
            {
                if (customerFirstName.Text != "" && customerLastName.Text != "")
                {
                    var customer = new Customer
                    {
                        CustomerID = CustId,
                        FirstName = customerFirstName.Text,
                        LastName = customerLastName.Text,
                        Email = email.Text,
                        PhoneNumber = phoneNumber.Text

                    };
                    shopManager.AddCustomer(customer);
                    shopManager.BindCustomer();

                    customerFirstName.Clear();
                    customerLastName.Clear();
                    email.Clear();
                    phoneNumber.Clear();
                }
                
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("Enter a value");
            }
            
        }

        private void AddCustomerGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Customer jyg = AddCustomerGrid.SelectedItem as Customer;
            //customerId.Text = jyg.CustomerID.ToString();
            //customerName.Text = jyg.CustomerName;
            //email.Text = jyg.Email;
            //phoneNumber.Text = jyg.PhoneNumber;

        }
    }
}
