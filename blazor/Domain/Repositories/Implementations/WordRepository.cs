namespace Domain.Repositories.Implementations;

public class WordRepository : ARepository<Word>, IWordRepository
{
    public WordRepository(VocabsDbContext context) : base(context) { }
}