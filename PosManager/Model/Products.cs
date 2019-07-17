using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosManager.Manager;

namespace PosManager
{
    public class Products
    {
        [Key]

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string CategoriesName { get; set; }
        public decimal ProductPrice { get; set; }
        public int AvailableQuantity { get; set; }
    }
}
