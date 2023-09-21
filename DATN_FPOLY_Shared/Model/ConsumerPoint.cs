using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN_FPOLY_Shared.Model
{
    public class ConsumerPoint
    {
        public Guid Id { get; set; }
        public string Point { get; set; }
        public int Status { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<HIstoryConsumerPoint> HIstoryConsumerPoints { get; set; }
    }
}
