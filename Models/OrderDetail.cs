using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MastersDetailsInMvc.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderMasterId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public OrderMaster OrderMaster { get; set; }
        
    }
}