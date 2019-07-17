using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosManager.InterfaceX
{
    interface IShopManager
    {
        bool AddProduct(Products product);
        bool DeleteProduct(Products product);
        bool AddSale(Sales sale);
        bool DeleteSale(Sales sale);
        bool AddSalesDetail(SalesDetail salesDetails);
        bool DeleteSalesDetail(SalesDetail salesDetails);
        bool AddCustomer(Customer customer);
        bool DeleteCustomer(Customer customer);
        bool AddCategorie(Categories categorie);
        bool DeleteCategorie(Categories categorie);

    }
}
