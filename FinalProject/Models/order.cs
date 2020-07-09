
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class order
    {
        [Key]
        public int orderId { get; set; }

        public string userId { get; set; }

        [DefaultValue("00/00/00")]
        public DateTime? orederDate { get; set; }

        public string orderAddress { get; set; }

        public decimal orderTotalPrice { get; set; }

        [MaxLength(10)]
        public string orderStatus { get; set; }

        public virtual List<orderItem> orderItems { get; set; }
    }
}
