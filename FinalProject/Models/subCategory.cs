using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class subCategory
    {
        [Key]
        public int subCategoryId { get; set; }

        [Required]
        [MaxLength(50 , ErrorMessageResourceName = "subCategoryValidation", ErrorMessageResourceType = typeof(Resource))]
        [Display(Name = "subCategoryName", ResourceType = typeof(Resource))]
        public string subCategoryName { get; set; }

        [Display(Name = "subCategoryPhoto", ResourceType = typeof(Resource))]
        public string subCategoryPhoto { get; set; }

        [ForeignKey("mainCategory")]
        [Required(ErrorMessageResourceName = "mandatoryMainCategoryforSubCategory", ErrorMessageResourceType = typeof(Resource))]
        public int mainCategoryId { get; set; }
        public virtual mainCategory MainCategory { get; set; }

        public virtual List<product> Products { get; set; }
    }
}
