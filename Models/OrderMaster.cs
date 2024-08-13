using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MastersDetailsInMvc.Models
{
    public class OrderMaster
    {
        public int OrderMasterId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Note { get; set; }
        public string Image { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}