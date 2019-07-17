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
    /// Interaction logic for ListCategories.xaml
    /// </summary>
    public partial class ListCategories : UserControl
    {
        public ShopManager shopManager;
        public ListCategories(Manager.ShopManager _shopeManager)
        {
            InitializeComponent();
            shopManager = _shopeManager;
            DataContext = this;
            shopManager.CategorieDatagrid = this.AddCategorieGrid;
            shopManager.BindCategorie();
        }

        

        private void AddCategorieGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void btnEdit_Click(object sender, SelectedCellsChangedEventArgs e)
        {
            //Convert.ToInt16(Id.Text) = (AddEnrollmentGrid.SelectedItem as Enrollments).EnrollmentID;
            //StudentNameCombo.Text = (AddEnrollmentGrid.SelectedItem as Enrollments).FullName;
            //email.Text = (AddEnrollmentGrid.SelectedItem as Enrollments).CourseName;
            //DateTime.Parse(DateOfEnrollment.Text) = (AddEnrollmentGrid.SelectedItem as Enrollments).DateOfEnrollment;


        }

        public void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = AddCategorieGrid.SelectedItem;
            if (selectedItem != null)
            {
                if (MessageBox.Show("Are you sure you want to Delete this record", "Warning",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    AddCategorieGrid.Items.Remove(selectedItem);

                    // cast selectedItem as categories

                    Categories objcat = selectedItem as Categories;
                    shopManager.DeleteCategorie(objcat);
                    MessageBox.Show("Record successfully deleted", "Response",
                        MessageBoxButton.OK, MessageBoxImage.Information);

                }
            }
        }
    }
}
