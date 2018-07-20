
using Dapper.Contrib.Extensions;


namespace DapperWithRepoPattern.Data.Models
{
    /// <summary>
    /// Represents a single person in a company.
    /// </summary>
    [Table("Person")]
    public class Person
    {
        /// <summary>
        /// The record id of the <see cref="Person"/>.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The first name of the <see cref="Person"/>.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the <see cref="Person"/>.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The age of the <see cref="Person"/>.
        /// </summary>
        public int Age { get; set; }
    }
}