using Entities.Concrete;
using Girilenler.Concrete;
using Melumatlar.Abstract;

namespace Melumatlar.Concrete.EfCarData
{
    public class EfCarData : EfDataRepositoryBase<Car>, ICarData
    {
        public List<DtoS> Joins()
        {
            using (DataContext context = new DataContext())
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
