using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Product
    {
        //Columns

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری می باشد")]
        [Display(Name = "دسته بندی")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری می باشد")]
        [Display(Name = "برند")]
        public int BrandId { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری می باشد")]
        [MaxLength(100)]
        [Display(Name = "نام کالا")]
        public string ModelName { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری می باشد")]
        [MaxLength(100)]
        [Display(Name = "شرح کالا")]
        public string Description { get; set; }

        //Relations

        public virtual Category Category { get; set; }
        public virtual Company Company { get; set; }
    }
}
