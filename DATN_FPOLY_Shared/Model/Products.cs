using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN_FPOLY_Shared.Model
{
    public class Products
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public int Status { get; set; }

        public virtual ICollection<Product_Items> ProductItems { get; set; }
        public Category Categorys { get; set; }

    }
}
