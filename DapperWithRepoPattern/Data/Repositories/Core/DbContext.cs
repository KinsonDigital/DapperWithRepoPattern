using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperWithRepoPattern.Data.Repositories.Core
{
    public class DbContext<Entity> : IDbContext<Entity>
    {
        public DbContext(string connectionString)
        {
            ConnectionString = connectionString;
            Connection = new SqlConnection(connectionString);
        }


        #region Props
        public string ConnectionString { get; set; }

        public SqlConnection Connection { get; set; }
        #endregion
    }
}