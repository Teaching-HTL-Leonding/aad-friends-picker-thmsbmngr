using Microsoft.EntityFrameworkCore;

namespace FriendApi.Data
{
    public class FriendDbContext : DbContext
    {
        public FriendDbContext(DbContextOptions<FriendDbContext> options) : base(options)
        {
            
        }

        public DbSet<Friend> Friends { get; set; }
    }
}