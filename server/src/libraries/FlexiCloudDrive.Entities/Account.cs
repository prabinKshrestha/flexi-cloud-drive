namespace FlexiCloudDrive.Entities;

public class Account: BaseEntity
{
    public long AccountId { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public override long Id { get => AccountId; set => AccountId = value; }
}
