﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MastersDetailsInMvc.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
    }
}