using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class rate
    {
        [Key]
        public int rateId { get; set; }

        public int userId { get; set; }
        
        [ForeignKey("product")]
        public int productId { get; set; }
        public virtual product Product { get; set; }

        public decimal? rateValue { get; set; }
    }
}
