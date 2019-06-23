using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Company
    {
        //Columns

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری می باشد")]
        [MaxLength(100)]
        [Display(Name = "نام انگلیسی")]
        public string Englishname { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری می باشد")]
        [MaxLength(100)]
        [Display(Name = "نام فارسی")]
        public string Persianname { get; set; }

        [Display(Name = "کشور")]
        public int CountryId { get; set; }

        //Relations

        public virtual Country Country { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
