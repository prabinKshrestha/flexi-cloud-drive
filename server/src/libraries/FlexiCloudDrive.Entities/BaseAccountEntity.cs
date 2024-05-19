namespace FlexiCloudDrive.Entities;

public abstract class BaseAccountEntity : BaseEntity, IBaseAccountEntity
{
    public long AccountId { get; set; }
    public virtual Account? Account { get; set; }
}

public interface IBaseAccountEntity
{
    long AccountId { get; set; }
}