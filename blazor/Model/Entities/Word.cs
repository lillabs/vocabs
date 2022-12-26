namespace Model.Entities;

[Table("WORDS_ST")]
public class Word
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("WORD_ID")]
    public int Id { get; set; }
    
    [Required]
    [Column("VALUE")]
    [StringLength(100)]
    public string Value { get; set; }
    
    [Required]
    [Column("LANGUAGE")]
    public ELanguage Language { get; set; }
}