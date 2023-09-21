using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN_FPOLY_Shared.Model
{
    public class Bill_Items
    {
        public Guid Id { get; set; }
        public Guid BillId { get; set; }
        public Guid Product_Items_Id { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Status { get; set; }


        public Bill Bills { get; set; }
        public Product_Items ProductItems { get; set; }
        public virtual ICollection<Reviews> Reviews { get; set; }
    }
}
