using DapperWithRepoPattern.Data.Models;
using DapperWithRepoPattern.Data.Repositories.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DapperWithRepoPattern.Data.Repositories
{
    public class PersonCompanyContext : DbContext<Person>
    {
        public PersonCompanyContext() : base(ConfigurationManager.ConnectionStrings["PersonCompany"].ConnectionString)
        {
        }
    }
}
