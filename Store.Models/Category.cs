using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Category
    {
        //Columns
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری می باشد")]
        [MaxLength(100)]
        [Display(Name = "دسته بندی")]
        public string Name { get; set; }

        //Relations

        public virtual List<Product> Products { get; set; }
    }
}
