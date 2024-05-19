using FlexiCloudDrive.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlexiCloudDrive.Data;

public class DirectoryMapping: BaseAccountEntityMapping<Entities.Directory>
{
    public override void Configure(EntityTypeBuilder<Entities.Directory> builder)
    {
        base.Configure(builder);

        builder.ToTable("Directories");

        builder.HasKey(x => x.DirectoryId);

        builder.Property(x => x.Name).HasMaxLength(250);

        builder.HasOne(x => x.ParentDirectory).WithMany().HasForeignKey(x => x.ParentDirectoryId);
    }
}