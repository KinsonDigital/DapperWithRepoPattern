using System.Collections.Generic;
using Dapper;
using DapperWithRepoPattern.Data.Models;

namespace DapperWithRepoPattern.Data.Repositories
{
    public class PersonRepository : Repository<Person>
    {
        public PersonRepository(PersonCompanyContext context) : base(context, nameof(Person))
        {
        }


        public IEnumerable<string> GetFirstNames()
        {
            var sql = $"SELECT FirstName FROM {nameof(Person)}";

            return Context.Connection.Query<string>(sql);
        }


        public IEnumerable<string> GetLastNames()
        {
            var sql = $"SELECT LastName FROM {nameof(Person)}";

            return Context.Connection.Query<string>(sql);
        }


        public IEnumerable<Person> GetPeopleInThirtySomething()
        {
            var sql = $"SELECT * FROM {nameof(Person)} WHERE Age >= 30 AND Age <= 39";

            return Context.Connection.Query<Person>(sql);
        }
    }
}
