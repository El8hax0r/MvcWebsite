using Microsoft.EntityFrameworkCore;
using MvcWebsite.Models;

namespace MvcWebsite.Data
{
    public class MvcWebsiteContext : DbContext
    {
        public MvcWebsiteContext(DbContextOptions<MvcWebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<Classes> Classes { get; set; }
    }
}