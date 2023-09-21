using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN_FPOLY_Shared.Model
{
    public class Color
    {
        public Guid Id { get; set; }    
        public string Name { get; set; }
        public int Status { get; set; }
        public virtual ICollection<Product_Items> ProductItems { get; set; }
    }
}
