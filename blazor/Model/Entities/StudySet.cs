namespace Model.Entities;

[Table("STUDY_SETS")]
public class StudySet
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("STUDY_SET_ID")]
    public int Id { get; set; }
    
    [Column("DIRECTORY_ID")]
    public int FolderId { get; set; }
    public Folder Folder { get; set; }
    
    
}