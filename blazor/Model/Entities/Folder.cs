namespace Model.Entities;

[Table("FOLDERS")]
public class Folder
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("FOLDER_ID")]
    public int Id { get; set; }
    
    [Column("PARENT_FOLDER_ID")]
    public int ParentFolderId { get; set; }
    public Folder ParentFolder { get; set; }
    
}