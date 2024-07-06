using DatingApp.WebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.WebAPI.Data
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; }
    }
}
