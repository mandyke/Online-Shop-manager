using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosManager
{
    public class Sales
    {
        public int SalesID { get; set; }
        public DateTime Dates { get; set; }
        public int QuantityPurchased { get; set; }
        public decimal Discount { get; set; }
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public string NewCustomer { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal AmountDue { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Balance { get; set; }
        public decimal AmountPaid { get; set; }
    }
}
