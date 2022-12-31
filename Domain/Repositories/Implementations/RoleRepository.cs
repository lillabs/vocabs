namespace Domain.Repositories.Implementations;

public class RoleRepository : ARepository<Role>, IRoleRepository {
    public RoleRepository(VocabsDbContext context) : base(context) {
    }
}