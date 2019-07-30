using MyDDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDD.Infrastruct.Data
{
    /// <summary>
    /// 泛型仓储，实现泛型仓储接口
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        void IRepository<TEntity>.Add(TEntity obj)
        {
            throw new NotImplementedException();
        }

        void IRepository<TEntity>.Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        System.Linq.IQueryable<TEntity> IRepository<TEntity>.GetAll()
        {
            throw new NotImplementedException();
        }

        TEntity IRepository<TEntity>.GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        int IRepository<TEntity>.SaveChenges()
        {
            throw new NotImplementedException();
        }

        void IRepository<TEntity>.Update(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
