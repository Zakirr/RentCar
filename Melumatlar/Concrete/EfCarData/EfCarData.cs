using Melumatlar.Abstract;
using Girilenler.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Melumatlar.Concrete.EfCarData
{
    public class EfCarData : EfDataRepositoryBase<Car>, ICarData
    {
        public List<DtoS> Joins()
        {
            using (DataContext context=new DataContext())
            {
                var result = from c in context.Car
                             join cl in context.Color
                             on c.ColorId equals cl.ColorId
                             select new DtoS { BrandId = c.BrandId, ColorId = cl.ColorId, ColorName = cl.ColorName };
                return result.ToList();
            }
        }
    }
}
