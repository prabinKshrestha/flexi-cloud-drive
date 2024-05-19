using FlexiCloudDrive.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlexiCloudDrive.Data;

public class FileMapping: BaseAccountEntityMapping<Entities.File>
{
    public override void Configure(EntityTypeBuilder<Entities.File> builder)
    {
        base.Configure(builder);

        builder.ToTable("Files");

        builder.HasKey(x => x.FileId);

        builder.Property(x => x.FileName).HasMaxLength(250);
        builder.Property(x => x.Extension).HasMaxLength(250);
        builder.Property(x => x.ContentType).HasMaxLength(250);

        builder.HasOne(x => x.Directory).WithMany().HasForeignKey(x => x.DirectoryId);
    }
}
