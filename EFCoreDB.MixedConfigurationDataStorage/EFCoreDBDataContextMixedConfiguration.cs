using EFCoreDB.Models.MixedConfiguration;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDB.MixedConfigurationDataStorage
{
    public class EFCoreDBDataContextMixedConfiguration : DbContext
    {
        public DbSet<ProcessMixedConfiguration> ProcessMC { get; set; }
        public DbSet<GroupMixedConfiguration> GroupMC { get; set; }
        public DbSet<PointMixedConfiguration> PointMC { get; set; }
        public DbSet<BlogMixedConfiguration> BlogMC { get; set; }
        public DbSet<PostMixedConfiguration> PostMC { get; set; }
        public DbSet<TagMixedConfiguration> TagMC { get; set; }
        public DbSet<BloggerMixedConfiguration> BloggerMC { get; set; }
        public DbSet<AddressMixedConfiguration> AddressMC { get; set; }

        public EFCoreDBDataContextMixedConfiguration()
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ABIDMAHMOOD\AMSQLSERVER;Database=EFCoreMixedConfigurationDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            MixedConfiguration.Configuration(modelBuilder);
        }
    }
}
