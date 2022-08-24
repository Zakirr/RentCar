using Entities.Concrete;
using Utilites.Abstract;

namespace Business.Abstract
{
    public interface IRentalsManager
    {
        IDataResult<Rentals> Add(Rentals rentals);
        IDataResult<Rentals> Return(Rentals rentals);
        IDataResult<List<Rentals>> GetAll();
    }
}
