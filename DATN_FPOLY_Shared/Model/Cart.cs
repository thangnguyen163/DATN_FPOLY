using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN_FPOLY_Shared.Model
{
    public class Cart
    {
        public Guid UserId { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }

        public User User { get; set; }
        public virtual ICollection<Cart_Items> CartItems { get; set; }

    }
}
