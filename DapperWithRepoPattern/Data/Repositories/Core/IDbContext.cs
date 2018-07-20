using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperWithRepoPattern.Data.Repositories.Core
{
    public interface IDbContext<Entity>
    {
        string ConnectionString { get; set; }
    }
}
