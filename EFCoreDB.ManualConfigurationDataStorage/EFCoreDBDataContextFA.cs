using EFCoreDB.Models.ManualConfiguration;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDB.ManualConfigurationDataStorage
{
    public class EFCoreDBDataContextFA : DbContext
    {
        public DbSet<ProcessFA> ProcessFA { get; set; }
        public DbSet<GroupFA> GroupFA { get; set; }
        public DbSet<PointFA> PointFA { get; set; }
        public DbSet<BlogFA> BlogFA { get; set; }
        public DbSet<PostFA> PostFA { get; set; }
        public DbSet<TagFA> TagFA { get; set; }
        public DbSet<BloggerFA> BloggerFA { get; set; }
        public DbSet<AddressFA> AddressFA { get; set; }

        public EFCoreDBDataContextFA()
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ABIDMAHMOOD\AMSQLSERVER;Database=EFCoreManualConfigurationDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            FAConfiguration.Configuration(modelBuilder);
        }
    }
}
