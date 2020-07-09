using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class productSubPhoto
    {
        [Key]
        public int photoId { get; set; }

        public string photoName { get; set; }

        [ForeignKey("product")]
        public int? productId { get; set; }
        public virtual product Product { get; set; }
    }
}
