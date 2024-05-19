namespace FlexiCloudDrive.Entities;

public abstract class BaseEntity: IBaseEntity
{
    public abstract long Id { get; set; }
    public long? CreatedById { get; set; }
    public long? UpdatedById { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime UpdatedOn { get; set; }
}

public interface IBaseEntity
{
    long Id { get; set; }
    long? CreatedById { get; set; }
    long? UpdatedById { get; set; }
    DateTime CreatedOn { get; set; }
    DateTime UpdatedOn { get; set; }
}