using DATN_FPOLY_Shared.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN_FPOLY_Shared.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {

        }

        public MyDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<AddressShip> AddressShips { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Bill_Items> BillItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Cart_Items> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ConsumerPoint> ConsumerPoints { get; set; }
        public DbSet<Formula> Formulas { get; set; }
        public DbSet<HIstoryConsumerPoint> HIstoryConsumerPoints { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Product_Items> ProductItems { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Promotions> Promotions { get; set; }
        public DbSet<Promotions_Product> PromotionsProducts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<Voucher_Bill> VoucherBills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
