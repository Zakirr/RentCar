using Melumatlar.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Melumatlar.Abstract
{
    public interface IDataRepository<T>
    {
        public void Add(T car);
        public void Delete(T car);
        public void Update(T car);
        public T Get(Expression<Func<T, bool>> filter);
        public List<T> GetAll(Expression<Func<T, bool>> filter = null);
    }
}
