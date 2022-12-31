namespace Model.Entities;

[Table("STUDY_SETS")]
public class StudySet
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("STUDY_SET_ID")]
    public int Id { get; set; }
    
    [Required]
    [Column("NAME")]
    public string Name { get; set; }
    
    [Column("DESCRIPTION")]
    public string? Description { get; set; }
    
    [Required]
    [Column("CREATED_AT")]
    public DateTime CreatedAt { get; set; }
    
    [Column("FOLDER_ID")]
    public int? FolderId { get; set; }
    public Folder? Folder { get; set; }
}