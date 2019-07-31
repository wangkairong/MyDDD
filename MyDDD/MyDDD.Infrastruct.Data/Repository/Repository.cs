using Microsoft.EntityFrameworkCore;
using MyDDD.Domain.Interfaces;
using MyDDD.Infrastruct.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDDD.Infrastruct.Data
{
    /// <summary>
    /// 泛型仓储，实现泛型仓储接口
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly StudyContext Db;
        protected readonly DbSet<TEntity> DbSet;


        public Repository(StudyContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }
       public virtual void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

       public virtual void Delete(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

       public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

       public virtual TEntity GetById(Guid id)
        {
            return DbSet.Find(id);
        }

       public int SaveChenges()
        {
            return Db.SaveChanges();
        }

       public virtual void Update(TEntity obj)
        {
            DbSet.Update(obj);
        }
    }
}
