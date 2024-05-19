namespace FlexiCloudDrive.Entities;

public class User: BaseAccountEntity
{
    public long UserId { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required string SaltKey { get; set; }

    public override long Id { get => UserId; set => UserId = value; }
}
