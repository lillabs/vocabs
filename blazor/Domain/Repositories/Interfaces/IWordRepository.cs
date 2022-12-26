using Model.Entities;

namespace Domain.Repositories.Interfaces;

public interface IWordRepository : IRepository<Word>
{
    Task<Word> GetWordById(int wordId, CancellationToken ct = default);

    Task<Word> GetKnownWordByWordpair(int wordpairId, CancellationToken ct = default);

    Task<Word> GetLearningWordByWordpair(int wordpairId, CancellationToken ct = default);
}