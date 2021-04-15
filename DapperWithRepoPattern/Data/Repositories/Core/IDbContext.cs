namespace DapperWithRepoPattern.Data.Repositories.Core
{
    public interface IDbContext<Entity>
    {
        string ConnectionString { get; set; }
    }
}
