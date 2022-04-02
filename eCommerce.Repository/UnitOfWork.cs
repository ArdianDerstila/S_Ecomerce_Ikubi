using eCommerce.Data;
using eCommerce.Repository.Interfaces;
using eCommerce.Repository.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eCommerce.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public AppDbContext Context { get; }
        private bool _disposed;
        private Dictionary<Type, object> _repositories;

        public UnitOfWork(AppDbContext context)
        {
            Context = context;
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if (!_disposed)
                if (disposing)
                    Context.Dispose();

            _disposed = true;
        }


        public IRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            if (_repositories == null)
                _repositories = new Dictionary<Type, object>();

            if (_repositories.Keys.Contains(typeof(TEntity)))
                return _repositories[typeof(TEntity)] as IRepository<TEntity>;

            var repository = new Repository<TEntity>(this);

            _repositories.Add(typeof(TEntity), repository);
            return repository;
        }



        public void Save()
        {
            Context.SaveChanges();
        }
    }
}
