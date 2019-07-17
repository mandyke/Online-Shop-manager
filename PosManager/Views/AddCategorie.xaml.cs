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
using PosManager.Model;

namespace PosManager.Views
{
    /// <summary>
    /// Interaction logic for AddCategorie.xaml
    /// </summary>
    
    public partial class AddCategorie : UserControl
    {
        SalesContextDB dB = new SalesContextDB();
        public ShopManager shopManager;
        int CatId = 0;
        public AddCategorie(Manager.ShopManager _shopManager)
        {
            
            InitializeComponent();
            shopManager = _shopManager;

            DataContext = this;
            AddCategorieGrid.ItemsSource = dB.Categorie.ToList();
            //if (shopManager.Categorie != null)
            //{
            //try
            //{
            //CategorieCombo.ItemsSource = shopManager.Categorie;
            //}
            //catch (Exception)
            //{


            //}


            //CategorieCombo.DisplayMemberPath = "CategorieName";
            // CategorieCombo.SelectedValuePath = "CategoryID";
            //}
            //shopManager.CategorieDatagrid = this.AddCategorieGrid;
            //shopManager.BindCategorie();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            CatId = CatId + 1;
            try
            {
                if (categorieName.Text != "" && CategorieCombo.Text != "")
                {
                    var categorie = new Categories
                    {
                        CategoryID = CatId,
                        CategorieName = categorieName.Text,
                        CategoryDescription = CategorieCombo.Text
                    };

                    dB.Categorie.Add(categorie);
                    dB.SaveChanges();
                    AddCategorieGrid.ItemsSource = dB.Categorie.ToList();

                    categorieName.Clear();
                    CategorieCombo.Clear();
                }
                else
                {
                    MessageBox.Show("Enter data in the empty fields");
                }


            }
            catch (Exception)
            {

                MessageBox.Show("You have empty fields");
            }
            
        }

        
    }
}
