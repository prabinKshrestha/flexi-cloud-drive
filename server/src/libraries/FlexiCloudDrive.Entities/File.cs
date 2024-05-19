namespace FlexiCloudDrive.Entities;

public class File: BaseAccountEntity
{
    public long FileId { get; set; }
    public required string Name { get; set; }
    public required string FileName { get; set; }
    public required string Extension { get; set; }
    public required string ContentType { get; set; }
    public required long Size { get; set; }
    public required string CloudFileName { get; set; }
    
    public long DirectoryId { get; set; }
    public virtual Directory? Directory { get; set; }

    public override long Id { get => FileId; set => FileId = value; }
}
