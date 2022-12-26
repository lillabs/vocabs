namespace Model.Entities;

[Table("WORDPAIRS")]
public class Wordpair
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("WORDPAIR_ID")]
    public int Id { get; set; }
    
    [Column("STUDY_SET_ID")]
    public int StudySetId { get; set; }
    public StudySet StudySet { get; set; }
    
    [Column("KNOWN_WORD_ID")]
    public int KnownWordId { get; set; }
    public Word KnownWord { get; set; }
    
    [Column("LEARNING_WORD_ID")]
    public int LearningWordId { get; set; }
    public Word LearningWord { get; set; }
}