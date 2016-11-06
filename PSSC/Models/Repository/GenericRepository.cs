using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CommonRepository
{
   public abstract class GenericRepository<C, R> :
        IGenericRepository<R> where R : class where C : DbContext, new()
    {
        private C _entities = new C();
        public C Context
        {
            get { return _entities; }
            set { _entities = value; }
        }
        public virtual IQueryable<R> GetAll()
        {
            IQueryable<R> query = _entities.Set<R>();
            return query;
        }
        public IQueryable<R> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            IQueryable<R> query = _entities.Set<R>().Where(predicate);
            return query;
        }
        public virtual void Add(R entity)
        {
            _entities.Set<R>().Add(entity);
        }
        public virtual void Delete(R entity)
        {
            _entities.Set<R>().Remove(entity);
        }
        public virtual void Edit(R entity)
        {
            _entities.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }
        public virtual void Save()
        {
            _entities.SaveChanges();
        }
    }
}
