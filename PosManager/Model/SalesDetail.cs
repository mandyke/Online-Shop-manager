using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosManager
{
    public class SalesDetail
    {
        [Key]
        public int SalesDetailsID { get; set; }
        public int SalesID { get; set; }
        public int ProductID { get; set; }
        public DateTime SalesDetailDates { get; set; }
        public int QuantityPurchased { get; set; }
        public decimal Discount { get; set; }
        public string SalesDetailCustomerName { get; set; }
        public string SalesProductName { get; set; }
        public decimal Total { get; set; }
        public decimal Balance { get; set; }
        public decimal AmountPaid { get; set; }

    }
}
