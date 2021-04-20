using EFCoreDB.Models.ManualConfiguration;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDB.ManualConfigurationDataStorage
{
    internal static class FAConfiguration
    {
        internal static void Configuration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProcessFA>().HasKey(process => process.ProcessFAPrimaryKey).HasName("ProcessFAPrimaryKey");
            modelBuilder.Entity<GroupFA>().HasKey(group => group.GroupFAPrimaryKey);
            modelBuilder.Entity<PointFA>().HasKey(point => point.PointFAPrimaryKey);
            modelBuilder.Entity<BlogFA>().HasKey(blog => blog.BlogFAPrimaryKey);
            modelBuilder.Entity<PostFA>().HasKey(post => post.PostFAPrimaryKey);
            modelBuilder.Entity<TagFA>().HasKey(tag => tag.TagFAPrimaryId);
            modelBuilder.Entity<BloggerFA>().HasKey(blogger => blogger.BloggerFAPrimaryKey);
            modelBuilder.Entity<AddressFA>().HasKey(address => address.AddressFAPrimaryKey);

            //Process-Group-Point
            modelBuilder.Entity<ProcessFA>().HasMany(process => process.GroupList).WithOne().HasForeignKey(g => g.ProcessFAForeignKey).HasConstraintName("ForeignKey_GroupFA_ProcessFA");
            modelBuilder.Entity<GroupFA>().HasMany(g => g.PointList).WithOne().HasForeignKey(point => point.GroupFAForeignKey).HasConstraintName("ForeignKey_PointFA_GroupFA");

            //process-Blog-Post-Tag
            modelBuilder.Entity<ProcessFA>().HasOne(process => process.BlogFA).WithOne(blog => blog.ProcessFA).HasForeignKey<BlogFA>(blog => blog.ProcessFAForeignKey).HasConstraintName("ForeignKey_BlogFA_ProcessFA");
            modelBuilder.Entity<BlogFA>().HasMany(blog => blog.PostList).WithOne().HasForeignKey(post => post.BlogFAForeignKey).HasConstraintName("ForeignKey_PostFA_BlogFA");
            modelBuilder.Entity<PostFA>().HasMany(post => post.TagList).WithMany(tag => tag.PostList).UsingEntity(j => j.ToTable("PostTags"));

            //Blog-Blogger-Address
            modelBuilder.Entity<BlogFA>().HasOne(blog => blog.BloggerFA).WithOne(blogger => blogger.BlogFA).HasForeignKey<BloggerFA>(blogger => blogger.BlogFAForeignKey).HasConstraintName("ForeignKey_BloggerFA_BlogFA");
            modelBuilder.Entity<BloggerFA>().HasOne(blogger => blogger.AddressFA).WithOne(address => address.BloggerFA).HasForeignKey<AddressFA>(address => address.BloggerFAForeignKey).HasConstraintName("ForeignKey_AddressFA_BloggerFA");

        }
    }
}
