using Business.Abstract;
using DataAcces.Abstract;
using Entities.Concrete;
using Utilites.Abstract;
using Utilites.Concrete;

namespace Business.Concrete
{
    public class CarImagesManager : ICarImagesService
    {

        ICarImagesData _imagesData;

        public CarImagesManager(ICarImagesData imagesData)
        {
            _imagesData = imagesData;
        }

        public IDataResult<CarImages> Add(CarImages images)
        {


         
            _imagesData.Add(images);
            return new DataSuccessResult<CarImages>("Sekil elave olundu");
        }

        public IDataResult<CarImages> Delete(CarImages images)
        {
            _imagesData.Delete(images);
            return new DataSuccessResult<CarImages>("Sekil silindi");
        }

        public IDataResult<CarImages> Update(CarImages images)
        {
            _imagesData.Update(images);
            return new DataSuccessResult<CarImages>("Ugurla yenilendi");
        }



        IDataResult<CarImages> CheckIfImagesCountisFive(int carId)
        {
            var result = _imagesData.GetAll(p => p.CarId == carId);
            if (result.Count > 5)
            {
                return new DataErrorResult<CarImages>("Bu masinin artiq 5 sekli var");

            }
            return new DataSuccessResult<CarImages>();
        }
    }
}
