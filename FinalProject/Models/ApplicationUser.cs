using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Display(Name ="Name")]
        [Required]
        [MinLength(8, ErrorMessage = "Name Shouldn't be less than 8 Characters")]
        [MaxLength(50, ErrorMessage = "Name Shouldn't be more than 50 Characters")]
        //[RegularExpression("[a-zA-Z]{8,}")]
        public string Name { get; set; }

        public ApplicationUser() :base() { }

    }
}
