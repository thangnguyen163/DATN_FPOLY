﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN_FPOLY_Shared.Model
{
    public class AddressShip
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Recipient { get; set; }
        public string DistrictID { get; set; }
        public string ProvinceID { get; set; }
        public string WardCode { get; set; }
        public string ToAddress { get; set; }
        public string NumberPhone { get; set; }
        public int Status { get; set; }


        public User Users { get; set; }
    }
}
