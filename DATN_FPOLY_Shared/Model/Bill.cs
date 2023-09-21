using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN_FPOLY_Shared.Model
{
    public class Bill
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string CreateDate { get; set; }
        public int TotalAmount { get; set; }
        public int Transport_Fee { get; set; }
        public string ShipCode { get; set; }
        public string Note { get; set; }
        public Guid History_ConsumerPoint_ID { get; set; }
        public int Status { get; set; }


        public User Users { get; set; }

        public HIstoryConsumerPoint HistoryConsumerPoints { get; set; }
        public virtual ICollection<Voucher_Bill> Voucher_Bills { get; set; }
        public virtual ICollection<Bill_Items> Bill_Items { get; set; }
    }
}
