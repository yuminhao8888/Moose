using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VIPProgramAssessment.Models;

namespace VIPProgramAssessment.ViewModels
{
    public class ProductDetailsViewModel
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int ColorId { get; set; }
        public int SizeId { get; set; }
        public List<ProductSize> SizeList { get; set; }
        public List<ProductColor> ColorList { get; set; }
    }
}