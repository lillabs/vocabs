namespace Model.Entities;

[Table("E_LANGUAGES")]
public class ELanguage
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [StringLength(50)]
    [Column("VALUE")]
    public string Value { get; set; }
}