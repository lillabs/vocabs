namespace Domain.Repositories.Implementations;

public class WordRepository : ARepository<Word>, IWordRepository
{
    public WordRepository(VocabsDbContext context) : base(context) { }
    public Task<Word> GetWordById(int wordId, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }

    public Task<Word> GetKnownWordByWordpair(int wordpairId, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }

    public Task<Word> GetLearningWordByWordpair(int wordpairId, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }
}