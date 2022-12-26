namespace Domain.Repositories.Implementations;

public class WordpairRepository : ARepository<Wordpair>, IWordpairRespository
{
    public WordpairRepository(VocabsDbContext context) : base(context) { }
    public Task<List<Wordpair>> GetWordpairsByStudySet(int studySetId, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }

    public Task<Wordpair> GetWordpairById(int wordpairId, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }

    public Task<bool> IsLearningWordCorrect(Word knownWord, Word learningWord, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }
}