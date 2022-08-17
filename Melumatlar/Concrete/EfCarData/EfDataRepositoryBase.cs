using Melumatlar.Abstract;
using Melumatlar.Concrete;
using Girilenler.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Melumatlar.Concrete.EfCarData
{
    public class EfDataRepositoryBase<T>:IDataRepository<T>
        where T:class,IEntity,new()
    {    public void Add(T car)
        {
            using (DataContext context = new DataContext())
            {
                var result = context.Entry(car);
                result.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(T car)
        {
            using (DataContext context = new DataContext())
            {
                var result = context.Entry(car);
                result.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public void Update(T car)
        {
            using (DataContext context = new DataContext())
            {
                var result = context.Entry(car);
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
