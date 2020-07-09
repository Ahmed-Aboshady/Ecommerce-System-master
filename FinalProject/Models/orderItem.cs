using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class orderItem
    {
        [Key]
        public int itemId { get; set; }

        [ForeignKey("order")]
        public int orderId { get; set; }
        public virtual order Order { get; set; }

        [ForeignKey("product")]
        public int productId { get; set; }
        public virtual product Product { get; set; }

        public int quantity { get; set; }

        public decimal subTotal { get; set; }
    }
}
