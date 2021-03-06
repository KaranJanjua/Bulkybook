using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulkybook.DataAccess.Repository.IRepository
{
    public interface IRepositroy<T> where T : class
    {
        T Get(int id);

        IEnumerable<T> GetAll(
            Expression<Func<T,bool >> filter = null,
            Func<IQueryable<T>,IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null
            );

        T GetFirstorDefault(
           Expression<Func<T, bool>> filter = null,
           string includeProperties = null
           );

        void Add(T entity);
        void Remove(int id);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entity);
    }
}
