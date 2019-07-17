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
    /// Interaction logic for AddSalesDetails.xaml
    /// </summary>
    public partial class AddSalesDetails : UserControl
    {
        public ShopManager shopManager;
        public AddSalesDetails(ShopManager _shopManager)
        {
            InitializeComponent();
            shopManager = _shopManager;
        }
    }
}
