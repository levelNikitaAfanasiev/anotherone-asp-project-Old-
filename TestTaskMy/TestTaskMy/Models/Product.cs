using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace TestTaskMy.Models
{

    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Display(Name = "Product Name")]
        public string Product_name { get; set; }
        public int? Category_typeId { get; set; }
        public Category_type Category_type { get; set; }
    }

}
