

using Microsoft.EntityFrameworkCore;

namespace GalconOrdersSystem.Models
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options) :base(options)
        { 

        }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
    }
}
