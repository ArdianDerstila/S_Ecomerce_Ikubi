using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity FindById(object id);
        void Update(TEntity entity);
        void Delete(object id);
        void Delete(TEntity entity);
        void Insert(TEntity entity);
        void InsertOrEdit(TEntity entity);
    }
}
