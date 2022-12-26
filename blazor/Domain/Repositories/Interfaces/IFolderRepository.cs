using Model.Entities;

namespace Domain.Repositories.Interfaces;

public interface IFolderRepository : IRepository<Folder>
{
    Task<Folder> GetFolderByUrl(string url, CancellationToken ct = default);
}