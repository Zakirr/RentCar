using System.Linq.Expressions;

namespace Melumatlar.Abstract
{
    public interface IDataRepository<T>
    {
        public void Add(T entity);
        public void Delete(T entity);
        public void Update(T entity);
        public T Get(Expression<Func<T, bool>> filter);
        public List<T> GetAll(Expression<Func<T, bool>> filter = null);
    }
}
