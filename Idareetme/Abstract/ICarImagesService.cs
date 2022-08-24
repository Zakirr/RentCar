using Entities.Concrete;
using Utilites.Abstract;

namespace Business.Abstract
{
    public interface ICarImagesService
    {

        IDataResult<CarImages> Add(CarImages images);
        IDataResult<CarImages> Delete(CarImages images);
        IDataResult<CarImages> Update(CarImages images);
    }
}
