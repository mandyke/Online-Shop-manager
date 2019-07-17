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
    /// Interaction logic for AddSales.xaml
    /// </summary>
    public partial class AddSales : UserControl
    {
        public ShopManager shopManager;
        DateTime date = DateTime.Now;
        int SaleId = 0;
        int SaleDetailsID = 0;
        int TotalQtyPurchased = 0;


        

        public AddSales(Manager.ShopManager _shopManager)
        {
            InitializeComponent();
            //List<Products> product = new List<Products>();
            //product.Add(new Products() { Amount = 590, ProductName = "Milo" });
            //product.Add(new Products() { Amount = 1590, ProductName = "Dittol" });
            //productNameCombo.ItemsSource = product;
            //productNameCombo.DisplayMemberPath = "ProductName";

            shopManager = _shopManager;
            DataContext = this;

            //Binding product name to Select Sale name ComboBox
            if(shopManager.Product != null)
            {
                productNameCombo.ItemsSource = shopManager.Product;
                productNameCombo.DisplayMemberPath = "ProductName";
                productNameCombo.SelectedValuePath = "ProductID";
            }

            //Binding Customer name to Select Sale name ComboBox
            if (shopManager.Customers != null)
            {
                customerNameCombo.ItemsSource = shopManager.Customers;
                customerNameCombo.DisplayMemberPath = "FullName";
                customerNameCombo.SelectedValuePath = "CustomerID";
            }
                        
            shopManager.SaleDatagrid = this.AddSalesGrid;
            shopManager.BindSales();
            //shopManager.BindProducts();
        }

        

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            SaleId += 1;
            var newDate = date.ToString("F");
            


            try
            {
                //decimal pric_1 = Convert.ToDecimal(price.Text);
                //decimal quant_1 = Convert.ToDecimal(quantity.Text);
                //decimal ProdPrice = pric_1 * quant_1;
                //subTotal.Text = ProdPrice.ToString();
                if (productNameCombo.Text !="" && quantity.Text !="" && customerNameCombo.Text !="" && price.Text != "")
                {
                    var sel = new Sales
                    {
                        SalesID = SaleId,
                        ProductName = productNameCombo.Text,
                        CustomerName = customerNameCombo.Text,
                        ProductPrice = Convert.ToDecimal(price.Text),
                        QuantityPurchased = Convert.ToInt16(quantity.Text),
                        Dates = DateTime.Parse(newDate),
                        TotalPrice = Convert.ToDecimal(price.Text) * Convert.ToInt16(quantity.Text)
                    };

                    var productStockbalance = shopManager.Product.Where(p => p.AvailableQuantity < 2);
                    foreach (var items in productStockbalance)
                    {

                    }

                    shopManager.AddSale(sel);
                    shopManager.BindSales();
                    shopManager.BindProducts();

                    //Calculate total quantity purchased
                    TotalQtyPurchased = shopManager.Sale.Sum(c => c.QuantityPurchased);

                    var NewAmount = shopManager.Sale.Sum(c => c.TotalPrice);
                    gridTotal.Text = NewAmount.ToString();
                    //salesId.Clear();
                    //customerNameCombo.Clear();
                    // salesDate.SelectedDate = null;
                    price.Clear();
                    quantity.Clear();
                    //subTotal.Clear();
                    //discount.Clear();
                    //product.Clear();



                }

                //Discount = Convert.ToDouble(discount.Text),
                //Amount = Convert.ToDecimal(amountPaid.Text),
                //Balance = Convert.ToDecimal(balance.Text),
            }
            catch (Exception)
            {
                MessageBox.Show("Enter valid Date");
                
            }
            



        }

        private void GrandTotal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double sum = 0;
                for (int i = 0; i < AddSalesGrid.Items.Count; i++)
                {
                    sum += (double.Parse((AddSalesGrid.Columns[5].GetCellContent(AddSalesGrid.Items[i]) as TextBlock).Text));
                }
                gridTotal.Text = sum.ToString();
                //var totall = gridTotal.Text;
                //double amount_2 = Convert.ToDouble(amountPaid.Text);
                //double balan = amount_2 - sum;
                //balance.Text = balan.ToString();

                var sel3 = new Sales
                {
                   // Amount = amount_2,
                    //Balance = balan,
                    //GrandTotal = sum
                    

                };
                shopManager.AddSale(sel3);
                shopManager.BindSales();
                shopManager.BindProducts();

               
               
                

            }
            catch (Exception)
            {

                MessageBox.Show("Enter the Amount paid");
            }
            
        }

        private void NewCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            NewCustomer mygee = new NewCustomer();
            mygee.ShowDialog();
        }

        private void AddSalesGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var details = AddSalesGrid.SelectedItem as Sales;
            customerNameCombo.Text = details.CustomerName;

        }

        private void ProductNameCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Products productX = productNameCombo.SelectedItem as Products;
            //price.Text = Convert.ToString(productX.Amount);
            var product = shopManager.Product.Where(p => p.ProductName == productX.ProductName);
            foreach (var item in product)
            {
                price.Text = item.ProductPrice.ToString();
            }

        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            //salesId.Clear();
            //customerNameCombo.Clear();
            //salesDate.SelectedDate = null;
            price.Clear();
            quantity.Clear();
           // subTotal.Clear();
            amountPaid.Clear();
            balance.Clear();
            shopManager.Sale.Clear();
            AddSalesGrid.Items.Clear();
        }

        private void Balance_Click(object sender, RoutedEventArgs e)
        {
            //double sum = 0;
            //for (int i = 0; i < AddSalesGrid.Items.Count; i++)
            //{
            //sum += (double.Parse((AddSalesGrid.Columns[5].GetCellContent(AddSalesGrid.Items[i]) as TextBlock).Text));
            //}
            //gridTotal.Text = sum.ToString();
            //var totall = gridTotal.Text;
            ///double amount_2 = Convert.ToDouble(amountPaid.Text);
            //double balan = amount_2 - sum;
            //balance.Text = balan.ToString();

            //var sel3 = new Sales
            //{
            // Amount = amount_2,
            // Balance = balan,
            // GrandTotal = sum


            //};
            //shopManager.AddSale(sel3);
            //shopManager.BindSales();
            //shopManager.BindProducts();

            //balance.Text = balan.ToString();
            decimal Balance = 0;
            if (amountPaid.Text != "" && gridTotal.Text != "")
            {
                decimal AmtDue = Convert.ToDecimal(gridTotal.Text);
                decimal AmtPaid = Convert.ToDecimal(amountPaid.Text);
                balance.Text = (AmtPaid - AmtDue).ToString();
            }

            Balance = Convert.ToDecimal(balance.Text);

            SaleDetailsID += 1;
            var newSalesDate = date.ToString("F");

            //SalesDetailsCustomerName = shopManager.Products.Where(p => p.ProductName == d.ProductName);

            var saleDetails = new SalesDetail
            {
                SalesDetailsID = SaleDetailsID,
                SalesID = SaleId,
                SalesDetailCustomerName = customerNameCombo.Text,
                SalesProductName = productNameCombo.Text,
                AmountPaid = Convert.ToDecimal(amountPaid.Text),
                Balance = Balance,
                Total = TotalQtyPurchased,
                SalesDetailDates = Convert.ToDateTime(newSalesDate),
            };
            shopManager.AddSalesDetail(saleDetails);
            shopManager.BindSalesDetail();
        }
       
    }
}



        