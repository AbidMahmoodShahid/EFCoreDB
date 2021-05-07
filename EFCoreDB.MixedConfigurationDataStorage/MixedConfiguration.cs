using EFCoreDB.Models.MixedConfiguration;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDB.MixedConfigurationDataStorage
{
    internal static class MixedConfiguration
    {
        internal static void Configuration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProcessMixedConfiguration>().HasKey(process => process.ProcessMCPrimaryKey).HasName("ProcessMCPrimaryKey");
            modelBuilder.Entity<GroupMixedConfiguration>().HasKey(group => group.GroupMCPrimaryKey);
            modelBuilder.Entity<PointMixedConfiguration>().HasKey(point => point.PointMCPrimaryKey);
            modelBuilder.Entity<BlogMixedConfiguration>().HasKey(blog => blog.BlogMCPrimaryKey);
            modelBuilder.Entity<PostMixedConfiguration>().HasKey(post => post.PostMCPrimaryKey);
            modelBuilder.Entity<TagMixedConfiguration>().HasKey(tag => tag.TagMCPrimaryId);
            modelBuilder.Entity<BloggerMixedConfiguration>().HasKey(blogger => blogger.BloggerMCPrimaryKey);
            modelBuilder.Entity<AddressMixedConfiguration>().HasKey(address => address.AddressMCPrimaryKey);

            //Process-Group-Point
            modelBuilder.Entity<ProcessMixedConfiguration>().HasMany(process => process.GroupList).WithOne().HasForeignKey(g => g.ProcessMCForeignKey).HasConstraintName("ForeignKey_GroupMC_ProcessMC");
            modelBuilder.Entity<GroupMixedConfiguration>().HasMany(g => g.PointList).WithOne().HasForeignKey(point => point.GroupMCForeignKey).HasConstraintName("ForeignKey_PointMC_GroupMC");

            //process-Blog-Post-Tag
            modelBuilder.Entity<ProcessMixedConfiguration>().HasOne(process => process.BlogMC).WithOne(blog => blog.ProcessMC).HasForeignKey<BlogMixedConfiguration>(blog => blog.ProcessMCForeignKey).HasConstraintName("ForeignKey_BlogMC_ProcessMC");//(1..0 : 1..1) --> (https://stackoverflow.com/questions/54497784/entity-framework-core-zero-or-one-to-zero-or-one-relation) 
            modelBuilder.Entity<BlogMixedConfiguration>().HasMany(blog => blog.PostList).WithOne().HasForeignKey(post => post.BlogMCForeignKey).HasConstraintName("ForeignKey_PostMC_BlogMC");
            //TODO AM: imp --> //Note: post and tag cant be added into eachothers list at the same time, since they will have the same key relation in the PostTags table
            modelBuilder.Entity<PostMixedConfiguration>().HasMany(post => post.TagList).WithMany(tag => tag.PostList).UsingEntity(j => j.ToTable("PostTagsMC"));

            //Blog-Blogger-Address
            //Note: must have one to one relationship between blog and blogger not one to zero or one
            modelBuilder.Entity<BlogMixedConfiguration>().HasOne(blog => blog.BloggerMC).WithOne(blogger => blogger.BlogMC).HasForeignKey<BloggerMixedConfiguration>(blogger => blogger.BlogMCForeignKey).HasConstraintName("ForeignKey_BloggerMC_BlogMC");
            modelBuilder.Entity<BloggerMixedConfiguration>().HasOne(blogger => blogger.AddressMC).WithOne(address => address.BloggerMC).HasForeignKey<AddressMixedConfiguration>(address => address.BloggerMCForeignKey).HasConstraintName("ForeignKey_AddressMC_BloggerMC");
        }
    }
}
