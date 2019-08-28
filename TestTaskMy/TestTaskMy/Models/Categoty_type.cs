using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestTaskMy.Models
{
    [Table("Category_types")]
    public class Category_type
    {
        [Key]
        public int? Id { get; set; }
        [Display(Name = "Category Type")]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
        public Category_type()
        {
            Products = new List<Product>();
        }
    }
}