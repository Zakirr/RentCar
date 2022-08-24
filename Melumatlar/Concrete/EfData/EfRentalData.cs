using DataAcces.Abstract;
using Entities.Concrete;
using Melumatlar.Concrete.EfCarData;

namespace DataAcces.Concrete.EfCarData
{
    public class EfRentalData : EfDataRepositoryBase<Rentals>, IRentalsData
    {
    }
}
