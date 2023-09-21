using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN_FPOLY_Shared.Model
{
    public class Reviews
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
        public Guid ImageId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }      
        public int Status { get; set; }


        public User Users { get; set; }
        public Products Products { get; set; }
        public Image Images { get; set; }
    }
}
