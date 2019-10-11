using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Conference.Areas.Admin.Models
{
    public class EditionViewModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = "Edition name can't be less than 4 characters")]
        [MaxLength(4)]
        public string Name { get; set; }
       
        public string TagLine { get; set; }
        [Required]
        [Range(2010, 2020)]

        public int Year { get; set; }
        [Required]
        public bool Active { get; set; }
    }
}
