using System.Text.RegularExpressions;
using Domain.Repositories.Interfaces;
using Model.Configuration;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class FolderRepository : ARepository<Folder>, IFolderRepository
{
    public FolderRepository(VocabsDbContext context) : base(context) { }

    public async Task<Folder> GetFolderByUrl(string url, CancellationToken ct = default)
    {
        url = url.Trim('/');
        var pathElements = url.Split('/');

        Folder parentfolder = new Folder();
        int parentId = 0;

        for (int i = 0; i < pathElements.Length - 1; i++)
        {
            var urlpart = pathElements[i];

            if (i == pathElements.Length - 1)
            {
                parentfolder = await (from folder in Context.Set<Folder>()
                    where folder.Name == urlpart
                    select folder).FirstAsync(cancellationToken: ct);
            }
            else
            {
                parentfolder = await (from folder in Context.Set<Folder>()
                    where folder.Name == urlpart
                    where folder.ParentFolderId == parentId
                    select folder).FirstAsync(cancellationToken: ct);
            }

            parentId = parentfolder.Id;
        }

        return parentfolder;
    }
}