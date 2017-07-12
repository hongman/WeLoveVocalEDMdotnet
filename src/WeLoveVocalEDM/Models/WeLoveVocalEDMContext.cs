using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WeLoveVocalEDM.Models
{
    public class ApplicationUser : IdentityUser { }

    public class WeLoveVocalEDMContext : IdentityDbContext<ApplicationUser>
    {
        public WeLoveVocalEDMContext(DbContextOptions<WeLoveVocalEDMContext> options)
            : base(options)
        {
            //2월14일 수정
            //ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
