using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class mainCategory
    {
        [Key]
        public int mainCategoryId { get; set; }

        [Required]
        [MaxLength(50 , ErrorMessageResourceName = "mainCategoryValidation", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "mainCategoryName", ResourceType = typeof(Resource))]
        public string mainCategoryName { get; set; }

        [Display(Name = "mainCategoryPhoto", ResourceType =typeof(Resource))]
        public string mainCategoryPhoto { get; set; }

        public virtual List<subCategory> SubCategories { get; set; }
    }
}
