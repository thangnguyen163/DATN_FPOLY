using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN_FPOLY_Shared.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NumberPhone { get; set; }
        public string Email { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public bool Sex { get; set; }
        public string RefreshToken { get; set; }
        public string TojenCreated { get; set; }
        public Guid RoleId { get; set; }
        public Guid ConsumerPointID { get; set; }
        public int Status { get; set; }
        public Role Roles { get; set; }
        public ConsumerPoint ConsumerPoints { get; set; }
        public virtual ICollection<Reviews> Reviews { get; set; }
        //public virtual IList<Bill> Bills { get; set; }
        public virtual ICollection<AddressShip> AddressShips { get; set; }
        public virtual ICollection<Voucher_Bill> VoucherBills { get; set; }

    }
}
