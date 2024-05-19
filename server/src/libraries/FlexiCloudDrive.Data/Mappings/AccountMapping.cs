using FlexiCloudDrive.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlexiCloudDrive.Data;

public class AccountMapping: BaseEntityMapping<Account>
{
    public override void Configure(EntityTypeBuilder<Account> builder)
    {
        base.Configure(builder);

        builder.ToTable("Accounts");

        builder.HasKey(x => x.AccountId);

        builder.Property(x => x.Name).HasMaxLength(250);
        builder.Property(x => x.Email).HasMaxLength(250);
    }
}
