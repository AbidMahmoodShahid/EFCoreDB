using EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace EFCoreDB.DataStorage
{
    public class EFCoreDBDataContext : DbContext
    {
        public DbSet<FDMProcessCC> FDMProcessCC { get; set; }
        public DbSet<FDMGroupCC> FDMGroupCC { get; set; }
        public DbSet<FDMPointCC> FDMPointCC { get; set; }
        public DbSet<FDMBlogCC> FDMBlogCC { get; set; }
        public DbSet<FDMPostCC> FDMPostCC { get; set; }
        public DbSet<FDMTagCC> FDMTagCC { get; set; }
        public DbSet<FDMBloggerCC> FDMBloggerCC { get; set; }
        public DbSet<FDMAddressCC> FDMAddressCC { get; set; }

        public EFCoreDBDataContext()
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ABIDMAHMOOD\AMSQLSERVER;Database=EFCoreConventionalConfigurationDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FDMPostCC>().HasMany(post => post.TagList).WithMany(tag => tag.PostList).UsingEntity(j => j.ToTable("PostTags"));
        }
    }
}
