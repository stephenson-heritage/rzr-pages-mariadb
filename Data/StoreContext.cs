using Microsoft.EntityFrameworkCore;

namespace rzr_pages_mariadb.Models
{
    public partial class StoreContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {
        }

    }
}