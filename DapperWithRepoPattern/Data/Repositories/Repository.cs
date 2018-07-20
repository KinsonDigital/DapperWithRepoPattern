using Dapper;
using Dapper.Contrib.Extensions;

using DapperWithRepoPattern.Data.Models;
using DapperWithRepoPattern.Data.Repositories.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperWithRepoPattern.Data.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        #region Props
        protected string TableName { get; set; }

        protected DbContext<TEntity> Context { get; set; }
        #endregion


        #region Constructors
        public Repository(DbContext<TEntity> context, string tableName)
        {
            TableName = tableName;
            Context = context;
        }
        #endregion


        #region Public Methods
        public void Add(TEntity entity)
        {
            Context.Connection.Insert(entity);
        }


        public void AddRange(IEnumerable<TEntity> entities)
        {
            Context.Connection.Insert<IEnumerable<TEntity>>(entities);
        }


        public IEnumerable<TEntity> Find(Predicate<TEntity> predicate)
        {
            var entities = GetAll();
            var result = new List<TEntity>();

            foreach (var entity in entities)
            {
                if (predicate(entity))
                    result.Add(entity);
            }


            return result;
        }


        public TEntity Get(int id)
        {
            return Context.Connection.Get<TEntity>(id);
        }


        public IEnumerable<TEntity> GetAll()
        {
            return Context.Connection.GetAll<TEntity>();
        }


        public IEnumerable<TEntity> GetAllWhere(Predicate<TEntity> predicate)
        {
            var entities = GetAll();
            var result = new List<TEntity>();

            foreach (var entity in entities)
            {
                if (predicate(entity))
                    result.Add(entity);
            }


            return result;
        }


        public void Remove(TEntity entity)
        {
            Context.Connection.Delete(entity);
        }


        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                Remove(entity);
            }
        }


        public TEntity SingleOrDefault(Predicate<TEntity> predicate)
        {
            var entities = Context.Connection.Query<TEntity>($"SELECT * FROM {TableName}");

            foreach (var entity in entities)
            {
                if (predicate(entity))
                    return entity;
            }


            return new TEntity();
        }
        #endregion
    }
}
