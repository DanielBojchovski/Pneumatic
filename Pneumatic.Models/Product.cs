using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pneumatic.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        [Range(1, 10000)]
        [Display(Name = "List Price")]
        public double ListPrice { get; set; }
        [Required]
        [Range(1, 10000)]
        [Display(Name = "Price for 1 tyre")]
        public double Price { get; set; } 
        [Required]
        [Range(1, 10000)]
        [Display(Name = "Price for 2 and 3 tyres")]
        public double Price2 { get; set; } 
        [Required]
        [Range(1, 10000)]
        [Display(Name = "Price for 4 or more tyres")]
        public double Price4 { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }
        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
        [Required]
        [Display(Name = "Season Type")]
        public int SeasonTypeId { get; set; }
        [ValidateNever]
        public SeasonType SeasonType { get; set; }

    }
}
