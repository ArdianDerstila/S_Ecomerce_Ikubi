using eCommerce.Entity;
using eCommerce.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eCommerce.Repository.Services
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly IUnitOfWork _unitOfWork;

        public Repository(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public virtual void Delete(object id)
        {
            var entity = _unitOfWork.Context.Set<TEntity>().Find(id);
            var objectState = entity as IObjectState;
            if (objectState != null)
                objectState.State = ObjectState.Deleted;
            Delete(entity);

        }

        public virtual void Delete(TEntity entity)
        {
            _unitOfWork.Context.Set<TEntity>().Attach(entity);
            _unitOfWork.Context.Set<TEntity>().Remove(entity);
        }

        public virtual TEntity FindById(object id)
        {
            return _unitOfWork.Context.Set<TEntity>().Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            _unitOfWork.Context.Set<TEntity>().Attach(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _unitOfWork.Context.Set<TEntity>().Attach(entity);
            var entry = _unitOfWork.Context.Entry(entity);
            entry.State = _unitOfWork.Context.GetState(ObjectState.Modified);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _unitOfWork.Context.Set<TEntity>().ToList();
        }

        public virtual void InsertOrEdit(TEntity entity)
        {
            if ((Int32)entity.GetType().GetProperty("Id").GetValue(entity, null) == 0)
                Insert(entity);
            else
                Update(entity);
        }
    }
}
