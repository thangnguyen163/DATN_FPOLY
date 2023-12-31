﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN_FPOLY_Shared.Model
{
    public class Product_Items
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid ColorId { get; set; }
        public Guid SizeId { get; set; }
        public Guid ImagesId { get; set; }
        public int AvaiableQuantity { get; set; }
        public int PurchasePrice { get; set; }
        public int CostPrice { get; set; }
        public int Status { get; set; }

        public Products Products { get; set; }
        public Color Colors { get; set; }
        public Size Size { get; set; }
        public Image Images { get; set; }
        public Cart_Items CartItems { get; set; }
    }
}
