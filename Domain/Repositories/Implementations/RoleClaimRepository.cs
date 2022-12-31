namespace Domain.Repositories.Implementations;

public class RoleClaimRepository : ARepository<RoleClaim>, IRoleClaimRepository {
    public RoleClaimRepository(VocabsDbContext context) : base(context) {
    }
}