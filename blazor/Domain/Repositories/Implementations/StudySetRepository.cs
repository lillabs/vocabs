using Domain.Repositories.Interfaces;
using Model.Configuration;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class StudySetRepository : ARepository<StudySet>, IStudySetRepository
{
    public StudySetRepository(VocabsDbContext context) : base(context) { }
}