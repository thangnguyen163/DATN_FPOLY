using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN_FPOLY_Shared.Model
{
    public class Promotions_Product
    {
        public Guid Id { get; set; }
        public Guid PromotionsId { get; set; }
        public Guid ProductItemsId { get; set; }
        public int Status { get; set; }

        public Promotions Promotions { get; set; }
        public Product_Items ProductItems { get; set; }
    }
}
