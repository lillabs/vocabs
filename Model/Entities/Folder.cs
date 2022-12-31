namespace Model.Entities;

[Table("FOLDERS")]
public class Folder
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("FOLDER_ID")]
    public int Id { get; set; }
    
    [Required]
    [Column("NAME")]
    public string Name { get; set; }
    
    [Column("DESCRIPTION")]
    public string? Description { get; set; }
    
    [Required]
    [Column("CREATED_AT")]
    public DateTime CreatedAt { get; set; }
    
    [Column("PARENT_FOLDER_ID")]
    public int? ParentFolderId { get; set; }
    public Folder? ParentFolder { get; set; }
}