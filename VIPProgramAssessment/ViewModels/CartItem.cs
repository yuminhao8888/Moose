using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VIPProgramAssessment.ViewModels
{
    public class CartItem
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int ProductColorId { get; set; }
        public int ProductSizeId { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }

    }
}