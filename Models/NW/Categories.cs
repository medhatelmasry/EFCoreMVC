using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCoreMVC.Models.NW
{
    public partial class Categories
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        public int CategoryId { get; set; }
        [Required(ErrorMessage = "You must enter the {0}.")]
        [Display(Name = "Category")]
        public string CategoryName { get; set; }
        [Required]
        //[DataType(DataType.EmailAddress)]

        [StringLength(30, ErrorMessage = "The {0} must be between {2} and {1} characters long.", MinimumLength = 6)]
        //[RegularExpression (pattern:"[a]{10}")]
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public ICollection<Products> Products { get; set; }
    }
}
