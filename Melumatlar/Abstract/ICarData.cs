using Entities.Concrete;
using Girilenler.Concrete;

namespace Melumatlar.Abstract
{
    public interface ICarData : IDataRepository<Car>
    {
        public List<DtoS> Joins();

    }
}
