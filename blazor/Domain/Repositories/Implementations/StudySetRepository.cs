using Domain.Repositories.Interfaces;
using Model.Configuration;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class StudySetRepository : ARepository<StudySet>, IStudySetRepository
{
    public StudySetRepository(VocabsDbContext context) : base(context)
    {
    }

    public Task<List<StudySet>> GetStudySetsByUrl(string url, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }

    public async Task<List<StudySet>> GetAllStudySets(CancellationToken ct = default)
    {
        return await
            (from studySet in Context.Set<StudySet>()
                select studySet).ToListAsync(cancellationToken: ct);
    }

    public async Task<List<StudySet>> GetRecentStudySets(CancellationToken ct = default)
    {
        return await
            (from studySet in Context.Set<StudySet>()
                orderby studySet.CreatedAt
                select studySet
            ).Take(6).ToListAsync(cancellationToken: ct);
    }
}