using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MastersDetailsInMvc.Models.ViewModels
{
    public class OrderVM
    {
        //Order Details
        public int OrderDetailId { get; set; }
        public int OrderMasterId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        // Order Master
        public DateTime OrderDate { get; set; }
        public string Note { get; set; }
        public string Image { get; set; }
        // ...
        public bool Terms { get; set; }

    }
}