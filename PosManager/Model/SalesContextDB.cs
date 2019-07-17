using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosManager.Model
{
    public class SalesContextDB : DbContext
    {
        public DbSet<Products> Product { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Categories> Categorie { get; set; }
        public DbSet<Sales> Sale { get; set; }
        public DbSet<SalesDetail> SalesDetails { get; set; }
    }
}
