using eCommerce.Data;
using eCommerce.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Repository
{
    public interface IUnitOfWork
    {
        AppDbContext Context { get; }
        void Dispose();
        void Save();
        void Dispose(bool disposing);
        IRepository<TEntity> Repository<TEntity>() where TEntity : class;
    }

}
