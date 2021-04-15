using System;
using System.Collections.Generic;

namespace DapperWithRepoPattern.Data.Repositories.Core
{
    public interface IRepository<TEntity> where TEntity : class
    {
        #region Methods
        TEntity Get(int id);


        IEnumerable<TEntity> GetAll();


        IEnumerable<TEntity> Find(Predicate<TEntity> predicate);


        TEntity SingleOrDefault(Predicate<TEntity> predicate);


        void Add(TEntity entity);


        void AddRange(IEnumerable<TEntity> entities);


        void Remove(TEntity entity);


        void RemoveRange(IEnumerable<TEntity> entities);
        #endregion
    }
}
