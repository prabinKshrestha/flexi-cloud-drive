using FlexiCloudDrive.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlexiCloudDrive.Data;

public class UserMapping: BaseAccountEntityMapping<Entities.User>
{
    public override void Configure(EntityTypeBuilder<Entities.User> builder)
    {
        base.Configure(builder);

        builder.ToTable("Users");

        builder.HasKey(x => x.UserId);

        builder.Property(x => x.Name).HasMaxLength(250);
        builder.Property(x => x.Email).HasMaxLength(250);
        builder.Property(x => x.Password).HasMaxLength(250);
        builder.Property(x => x.SaltKey).HasMaxLength(250);
    }
}