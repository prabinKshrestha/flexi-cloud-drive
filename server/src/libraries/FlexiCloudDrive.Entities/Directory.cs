namespace FlexiCloudDrive.Entities;

public class Directory: BaseAccountEntity
{
    public long DirectoryId { get; set; }
    public required string Name { get; set; }

    public int? ParentDirectoryId { get; set; }
    public virtual Directory? ParentDirectory { get; set; }

    public override long Id { get => DirectoryId; set => DirectoryId = value; }
}
