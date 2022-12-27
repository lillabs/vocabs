using Model.Entities;

namespace Domain.Repositories.Interfaces;

public interface IStudySetRepository : IRepository<StudySet>
{
    Task<List<StudySet>> GetStudySetsByUrl(string url, CancellationToken ct = default);

    Task<List<StudySet>> GetAllStudySets(CancellationToken ct = default);

    Task<List<StudySet>> GetRecentStudySets(CancellationToken ct = default);
}