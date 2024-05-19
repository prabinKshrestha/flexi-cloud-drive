using FlexiCloudDrive.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlexiCloudDrive.Data;

public class BaseAccountEntityMapping<TEntity> : BaseEntityMapping<TEntity> where TEntity: BaseAccountEntity
{
    public override void Configure(EntityTypeBuilder<TEntity> builder)
    {
        base.Configure(builder);
        builder.HasOne(x => x.Account);
    }
}
