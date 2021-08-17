using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebsite.Models
{
    public class DisplayPersonModel
    {
        public int ID { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Name is too long.")]
        [MinLength(3, ErrorMessage = "Name is too short.")]
        public string name { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Category is too long.")]
        [MinLength(5, ErrorMessage = "Category is too short.")]
        public string category { get; set; }
    }
}
