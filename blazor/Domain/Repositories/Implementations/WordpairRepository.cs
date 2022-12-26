namespace Domain.Repositories.Implementations;

public class WordpairRepository : ARepository<Wordpair>, IWordpairRespository
{
    public WordpairRepository(VocabsDbContext context) : base(context) { }
}