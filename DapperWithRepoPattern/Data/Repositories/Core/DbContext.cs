using System.Data;

namespace DapperWithRepoPattern.Data.Repositories.Core
{
    public class DbContext<Entity> : IDbContext<Entity>
    {
        public DbContext(string connectionString)
        {
            ConnectionString = connectionString;
            Connection = (IDbConnection)new SqlConnection(connectionString);
        }


        #region Props
        public string ConnectionString { get; set; }

        public IDbConnection Connection { get; set; }
        #endregion
    }
}