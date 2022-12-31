using Model.Entities;

namespace Domain.Repositories.Interfaces;

public interface IWordpairRespository : IRepository<Wordpair>
{
    Task<List<Wordpair>> GetWordpairsByStudySet(int studySetId, CancellationToken ct = default);

    Task<Wordpair> GetWordpairById(int wordpairId, CancellationToken ct = default);

    Task<bool> IsLearningWordCorrect(Word knownWord, Word learningWord, CancellationToken ct = default);

    // Task<bool> IsLearningWordCorrectNicely(Word knownWord, Word learningWord, CancellationToken ct = default);
}