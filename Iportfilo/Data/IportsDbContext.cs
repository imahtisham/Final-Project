using Iportfilo.Model;
using Microsoft.EntityFrameworkCore;

namespace Iportfilo.Data
{
    public class IportsDbContext : DbContext
    {
        public IportsDbContext(DbContextOptions<IportsDbContext> options) : base(options)
        {

        }
        public DbSet<SocialNetwork> tbl_Social { get; set; }
        public DbSet<Contect> tbl_Context { get; set; }
        public DbSet<Education> tbl_Edu { get; set; }
        public DbSet<Experience> tbl_Exp { get; set; }
        public DbSet<Fact> tbl_Fact { get; set; }
        public DbSet<Iportfiloes> tbl_Iport { get; set; }
        public DbSet<Services> tbl_Ser { get; set; }
        public DbSet<Skill> tbl_Skil { get; set; }
        public DbSet<Testimonial> tbl_test{ get; set; }

    }
}
