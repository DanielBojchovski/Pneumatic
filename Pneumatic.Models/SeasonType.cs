using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pneumatic.Models
{
    public class SeasonType
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Season Type")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

    }
}
