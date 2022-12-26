using Domain.Repositories.Interfaces;
using Model.Configuration;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class FolderRepository : ARepository<Folder>, IFolderRepository
{
    public FolderRepository(VocabsDbContext context) : base(context) { }
}