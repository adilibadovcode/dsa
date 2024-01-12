using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Twitter.Core.Entities;

namespace Twitter.DAL.Configurations;
public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.Property(x => x.Content).IsRequired().HasMaxLength(1024);
        builder.HasOne(x => x.AppUser).WithMany(x => x.Comments).HasForeignKey(x => x.AppUserId).OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(x => x.Post).WithMany(x => x.Comments).HasForeignKey(x => x.PostId).OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(x => x.ParentCommet).WithMany(x => x.Childs).HasForeignKey(x => x.ParentCommetId).OnDelete(DeleteBehavior.Restrict);
    }
}
