using FlexiCloudDrive.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlexiCloudDrive.Data;

public class BaseEntityMapping<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity: BaseEntity
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.Ignore(x => x.Id);
    }
}
