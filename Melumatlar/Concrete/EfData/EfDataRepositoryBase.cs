using Melumatlar.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Melumatlar.Concrete.EfCarData
{
    public class EfDataRepositoryBase<T> : IDataRepository<T>
        where T : class, IEntity, new()
    {
        public void Add(T entity)
        {
            using (DataContext context = new DataContext())
            {

                var result = context.Entry(entity);
                result.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (DataContext context = new DataContext())
            {
                var result = context.Entry(entity);
                result.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public void Update(T entity)
        {
            using (DataContext context = new DataContext())
            {
                var result = context.Entry(entity);
                result.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public T Get(Expression<Func<T, bool>> filter)
        {
            using (DataContext context = new DataContext())
            {
                return context.Set<T>().SingleOrDefault(filter);
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (DataContext context = new DataContext())
            {
                var result = filter == null ? context.Set<T>().ToList() : context.Set<T>().Where(filter).ToList();
                return result;
            }

        }
    }
}
