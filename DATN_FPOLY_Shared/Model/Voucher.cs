﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN_FPOLY_Shared.Model
{
    public class Voucher
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Reduced_Value { get; set; }
        public int Quantity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Discount_Conditions { get; set; }
        public int Status { get; set; }
        public virtual ICollection<Voucher_Bill> Voucher_Bills { get; set; }
        //public virtual ICollection<Cart> Carts { get; set; }
    }
}
