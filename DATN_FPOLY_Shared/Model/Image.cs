using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN_FPOLY_Shared.Model
{
    public class Image
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PathImage { get; set; }
        public Guid ProductItemId { get; set; }
        public int Status { get; set; }

        public Product_Items ProductItems { get; set; }
        public virtual ICollection<Reviews> Reviews { get; set; }

    }
}
