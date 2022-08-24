using DataAcces.Abstract;
using Entities.Concrete;
using Melumatlar.Concrete.EfCarData;

namespace DataAcces.Concrete.EfCarData
{
    public class EfCustomersData : EfDataRepositoryBase<Customers>, ICustomersData
    {
    }
}
