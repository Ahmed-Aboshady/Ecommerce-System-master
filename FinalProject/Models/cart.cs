
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class cart
    {
        [Key]
        public int cartId { get; set; }

        [ForeignKey("product")]
        public int productId { get; set; }
        public product product { get; set; }

        public int quantity { get; set; }

        public decimal cartSubTotal { get; set; }
    }
}
