using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Models.CommonRepository
{
    interface IGenericRepository<R> where R : class
    {
        IQueryable<R> GetAll();
        IQueryable<R> FindBy(Expression<Func<R, bool>> predicate);
        void Add(R entity);
        void Delete(R entity);
        void Edit(R entity); 
        void Save();
    }
}
