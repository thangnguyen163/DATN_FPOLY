﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN_FPOLY_Shared.Model
{
    public class Voucher_Bill
    {
        public Guid Id { get; set; }
        public Guid VoucherId { get; set; }
        public Guid UserId { get; set; }
        public int Status { get; set; }

        public User Users { get; set; }
        public Voucher Voucher { get; set; }


    }
}
