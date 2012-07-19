using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        //Create
        void Add(TEntity entity);

        //Read
        TEntity Load(object id);
        IQueryable<TEntity> Get();

        //Update
        void Update(TEntity entity);

        //Delete
        void Delete(object id);
        void Delete(TEntity entity);
    }
}
