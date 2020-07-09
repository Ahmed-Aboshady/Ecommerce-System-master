using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class penddingOrder
    {
        [Key]
        public int pendingId { get; set; }
        public int prod_id { get; set; }
        public string user_id { get; set; }

    }
}
