using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN_FPOLY_Shared.Model
{
    public class Cart_Items
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid Product_Item_Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }

        public Product_Items ProductItems { get; set; }
        public Cart_Items CartItems { get; set; }
    }
}
