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
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : UserControl
    {
        public ShopManager shopManager;
        int prodId = 0;
        int CateId = 0;

        public AddProduct(Manager.ShopManager _shopManager)
        {
            InitializeComponent();

            shopManager = _shopManager;

            DataContext = this;
            if (shopManager.Categorie != null)
            {
                CategorieCombo.ItemsSource = shopManager.Categorie;
                CategorieCombo.DisplayMemberPath = "CategoryDescription";
                CategorieCombo.SelectedValuePath = "CategoryID";
            }
            //Binding category name to select product name Combox
            //shopManager.ProductCategoryCombo = this.CategorieCombo;
            //shopManager.BindProductCategoryComboBox();

            //Binding input to product datagrid
            shopManager.ProductDatagrid = this.AddProductGrid;
            shopManager.BindProducts();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            prodId += 1;
            try
            {
                var categoryId = new Categories
                {
                    CategoryID = CateId
                };
                if(productName.Text != "" && productPrice.Text != "" &&  CategorieCombo.Text != "" & availableQuantity.Text != "")
                {
                    var product = new Products
                    {
                        ProductID = prodId,
                        ProductName = productName.Text,
                        CategoriesName = CategorieCombo.Text,
                        ProductPrice = Convert.ToDecimal(productPrice.Text),
                        AvailableQuantity = Convert.ToInt16(availableQuantity.Text)
                    };

                    shopManager.AddProduct(product);
                    shopManager.BindProducts();

                    productPrice.Clear();
                    productName.Clear();
                    CategorieCombo.SelectedItem = null;
                    availableQuantity.Clear();
                }
               
            }
            catch (Exception)
            {

                MessageBox.Show("Check input fields");
            }
            
        }

        
    }
}
