
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class product
    {
        [Key]
        public int productId { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "ProductName" , ResourceType = typeof(Resource))]
        public string productName { get; set; }

        [Required]
        [Display(Name = "ProductQuantity", ResourceType = typeof(Resource))]
        public int productQuantity { get; set; }

        [Display(Name = "ProductDescription", ResourceType = typeof(Resource))]
        public string productDescription { get; set; }

        [MaxLength(20)]
        [Display(Name = "ProductColor", ResourceType = typeof(Resource))]
        public string productColor { get; set; }

        [Required]
        [Display(Name = "ProductPrice", ResourceType = typeof(Resource))]
        public decimal productPrice { get; set; }

        [Display(Name = "ProductDiscount", ResourceType = typeof(Resource))]
        public decimal? discountValue { get; set; }

        [Display(Name = "ProductPhoto", ResourceType = typeof(Resource))]
        public string productPhoto { get; set; }
        
        [MaxLength(20)]
        [Display(Name = "brandName", ResourceType = typeof(Resource))]
        public string brandName { get; set; }

        [DefaultValue("00/00/00")]
        [Display(Name = "ProductAddDate", ResourceType = typeof(Resource))]
        public DateTime? productAddDate { get; set; }

        public decimal? productAverageRate { get; set; }

        //[ForeignKey("mainCategory")]
        //[Display(Name = "ProductMainCategory", ResourceType = typeof(Resource))]
        //[Required(ErrorMessageResourceName = "mandatoryMainCategoryforProduct", ErrorMessageResourceType = typeof(Resource))]
        //public int mainCategoryId { get; set; }
        //public virtual mainCategory mainCategory { get; set; }

        [ForeignKey("subCategory")]
        [Display(Name = "ProductSubCategory", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = "mandatorySubCategoryforProduct", ErrorMessageResourceType = typeof(Resource))]
        public int subCategoryId { get; set; }
        public virtual subCategory SubCategory { get; set; }

        public virtual List<productSubPhoto> ProductSubPhotos { get; set; }

        public virtual List<rate> Rates { get; set; }
    }
}
