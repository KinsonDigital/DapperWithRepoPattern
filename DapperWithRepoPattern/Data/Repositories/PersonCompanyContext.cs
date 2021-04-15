using DapperWithRepoPattern.Data.Models;
using DapperWithRepoPattern.Data.Repositories.Core;

namespace DapperWithRepoPattern.Data.Repositories
{
    public class PersonCompanyContext : DbContext<Person>
    {
        public PersonCompanyContext()
            : base("Data Source=OF3038635-10L01;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
        }
    }
}
