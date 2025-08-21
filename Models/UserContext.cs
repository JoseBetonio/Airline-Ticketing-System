using Microsoft.EntityFrameworkCore;
using TicketingAPI.Models;
namespace TicketingAPI.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }
        public DbSet<UserModel> Users => Set<UserModel>();
    }
}