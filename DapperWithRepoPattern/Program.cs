using DapperWithRepoPattern.Data.Models;
using DapperWithRepoPattern.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DapperWithRepoPattern
{
    class Program
    {
        private static string _connectionString = @"Server=localhost;Database=master;Trusted_Connection=True;";


        static void Main(string[] args)
        {
            DapperWithRepository();
        }


        /// <summary>
        /// This gets the data from the database using the repositories.
        /// </summary>
        static void DapperWithRepository()
        {
            var dbContext = new PersonCompanyContext();
            var personRepo = new PersonRepository(dbContext);

            var peopleToAdd = CreateManyPeople();

            //personRepo.AddRange(peopleToAdd);

            //personRepo.Add(new Person()
            //{
            //    FirstName = "Mighty",
            //    LastName = "Mouse",
            //    Age = 89
            //});


            var result = personRepo.GetAllWhere((person) => person.FirstName == "Mighty");

            var peopleInThirties = personRepo.GetPeopleInThirtySomething();

            var allPeople = personRepo.GetAll();
            var firstNames = personRepo.GetFirstNames();
            var lastNames = personRepo.GetLastNames();
            var jane = personRepo.Get(2);

            var foundItem = personRepo.SingleOrDefault((person) =>
            {
                return person.Id == 13;
            });


            var peopleOver25 = personRepo.Find((person) =>
            {
                return person.Age > 25;
            });

            Console.WriteLine($"Total People: {allPeople.Count()}");

            Console.ReadKey();
        }


        static List<Person> CreateManyPeople()
        {
            var people = new List<Person>();

            var random = new Random();

            for (int i = 0; i < 20; i++)
            {
                people.Add(new Person()
                {
                    FirstName = $"Bugs{i}",
                    LastName = $"Bunny{i}",
                    Age = random.Next(18, 65)
                });
            }

            return people;
        }
    }
}
