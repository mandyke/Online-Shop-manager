using PosManager.InterfaceX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PosManager.Manager
{

    public class ShopManager : IShopManager
    {
        public List<Products> Product { get; set; }
        public List<Categories> Categorie { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Sales> Sale { get; set; }
        public List<SalesDetail> SalesDetails { get; set; }
        public DataGrid ProductDatagrid { get; set; }
        public DataGrid CategorieDatagrid { get; set; }
        public DataGrid CustomersDatagrid { get; set; }
        public DataGrid SaleDatagrid { get; set; }
        public DataGrid SalesDetailsDatagrid { get; set; }

        public ComboBox ProductCategoryCombo { get; set; }
        public ComboBox ProductNameCombo { get; set; }
        public ComboBox SalesCustomerNameCombo { get; set; }

        public bool AddProduct(Products product)
        {
            try
            {
                if (Product == null)
                    Product = new List<Products>();

                Product.Add(product);
                BindProducts();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteProduct(Products product)
        {
            Product.Remove(product);
            //BindProducts();

            return true;
        }

        //public bool UpdateProduct(Products product)


        //public void BindProducts(DataGrid dataGrid)
        //{
            //dataGrid.Items.Clear();

            //dataGrid.DataContext = Products;

            //foreach (var item in Product)
            //{
               // dataGrid.Items.Add(item);
            //}
            
       // }

        public void BindProducts()
        {
            try
            {
                ProductDatagrid.Items.Clear();
                
                //dataGrid.DataContext = Products;

                if(Product != null)
                {
                    foreach (var item in Product)
                    {
                        ProductDatagrid.Items.Add(item);
                    }
                }
                
            }
            catch (Exception)
            {

            }
        }

        public bool AddSale(Sales sale)
        {
            try
            {
                if (Sale == null)
                    Sale = new List<Sales>();

                Sale.Add(sale);
                BindSales();
                return true;
                
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool DeleteSale(Sales sale)
        {
            Sale.Remove(sale);
            //BindSales();

            return true;
        }

        //public bool UpdateSale();

        public void BindSales()
        {
            try
            {
                SaleDatagrid.Items.Clear();

                // dataGrid.DataContext = Sales;

                if (Sale != null)
                {
                    foreach (var item in Sale)
                    {
                        SaleDatagrid.Items.Add(item);
                    }
                }
                
            }
            catch (Exception)
            {

                
            }
        }

        public void BindSalesCustomerNameCombo()
        {
           SalesCustomerNameCombo.Items.Clear();

            if (Customers != null)
            {
                foreach (var item in Customers)
                {
                    SalesCustomerNameCombo.Items.Add(item);
                }
            }
        }

         public void BindProductCategoryComboBox()
         {
           ProductCategoryCombo.Items.Clear();

            if(Categorie != null)
            {
                foreach(var item in Categorie)
                {
                    ProductCategoryCombo.Items.Add(item);
                }
            }
         }

        public void BindProductNameComboBox()
        {
            ProductNameCombo.Items.Clear();

            if(Product != null)
            {
                foreach(var item in Product)
                {
                    ProductNameCombo.Items.Add(item);
                }
            }
        }

        public void CalculateSales(int amount, int quantity)
        {
            var Total = 0;
            if (Sale != null)
            {
                Total = amount * quantity;
            }
        }



        public bool AddSalesDetail(SalesDetail salesDetails)
        {
            try
            {
                if (SalesDetails == null)
                    SalesDetails = new List<SalesDetail>();

                SalesDetails.Add(salesDetails);
                BindSalesDetail();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool DeleteSalesDetail(SalesDetail salesDetails)
        {
            SalesDetails.Remove(salesDetails);
            BindSalesDetail();

            return true;
        }

        // public bool UpdateSalesDetails()

        //public void BindSalesDetail(DataGrid dataGrid)
        //{
           // dataGrid.Items.Clear();

            // dataGrid.DataContext = SalesDetails;

            //foreach (var item in SalesDetails)
            //{
               // dataGrid.Items.Add(item);
            //}
       //}

        public void BindSalesDetail()
        {
            try
            {
                SalesDetailsDatagrid.Items.Clear();
                if (Sale != null)
                {
                    foreach (var item in SalesDetails)
                    {
                        SalesDetailsDatagrid.Items.Add(item);
                    }
                }
            }
            catch (Exception)
            {

                
            }
        }

        public bool AddCustomer(Customer customer)
        {
            try
            {
                if (Customers == null)
                    Customers = new List<Customer>();

                Customers.Add(customer);
                BindCustomer();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteCustomer(Customer customer)
        {
            Customers.Remove(customer);
            BindCustomer();

            return true;
        }

        //public bool UpDateCustomer(Customer customer)

        //public void BindCustomer(DataGrid dataGrid)
        //{
            //dataGrid.Items.Clear();

            // dataGrid.DataContext = Customer;
            //foreach (var item in Customers)
            //{
                //dataGrid.Items.Add(item);
            //}
       // }

        public void BindCustomer()
        {
            try
            {
                CustomersDatagrid.Items.Clear();

                //dataGrid.DataContext = Customer;
                if(Customers != null)
                {
                    foreach (var item in Customers)
                    {
                        CustomersDatagrid.Items.Add(item);
                    }
                }
                
            }
            catch (Exception)
            {

                
            }
        }

        public bool AddCategorie(Categories categorie)
        {
            try
            {
                if (Categorie == null)
                    Categorie = new List<Categories>();

                Categorie.Add(categorie);
                BindCategorie();
                return true;
            }
            catch (Exception )
            {

                return false;
            }
        }

        public bool DeleteCategorie(Categories categorie)
        {
            Categorie.Remove(categorie);
            //BindCategorie();

            return true;
        }

        public bool UpdateCategories(Categories categorie)
        {
            var _category = Categorie.Where(c => c.CategoryID == categorie.CategoryID).FirstOrDefault();
            _category = categorie;
            return true;
        }

       // public void BindCategorie(DataGrid dataGrid)
        //{
            //dataGrid.Items.Clear();

            //dataGrid.DataContext = Categories;

           // foreach (var item in Categorie)
            //{
               // dataGrid.Items.Add(item);
           // }
       // }

        public void BindCategorie()
        {
            try
            {
                CategorieDatagrid.Items.Clear();

                // dataGrid.DataContext = Categories;
                if(Categorie != null) { 
                    foreach (var item in Categorie)
                    {
                        CategorieDatagrid.Items.Add(item);
                    }
                }
            }
            catch (Exception)
            {

                
            }
        }

        
    }
    
}
