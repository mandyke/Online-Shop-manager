using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PosManager
{
    public class Categories
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategorieName { get; set; }
        public string CategoryDescription { get; set; }
       
    }
}
