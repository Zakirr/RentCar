using Business.Abstract;
using CoreAndUtilites.Helpers;
using CoreAndUtilites.Utilities.Business;
using DataAcces.Abstract;
using Entities.Concrete;
using Utilites.Abstract;
using Utilites.Concrete;

namespace Business.Concrete
{
    public class CarImagesManager : ICarImagesService
    {

        ICarImagesData _imagesData;
        WebHelper webHelper = new WebHelper();
        public CarImagesManager(ICarImagesData imagesData)
        {
            _imagesData = imagesData;
        }

        public IDataResult<CarImages> Add(CarImages images,string zroot)
        {
            var result=BusinessRules<CarImages>.Run(CheckIfImagesCountisFive(images.CarId));
            if (result!=null)
            {
                return result;
            }
            webHelper.Add(images.files, zroot);
            images.Date = DateTime.Now.ToString("d");
            images.ImagePath = webHelper.rootPlusGuid;
            _imagesData.Add(images);
            return new DataSuccessResult<CarImages>("Sekil elave olundu");

        }

        public IDataResult<CarImages> Delete(CarImages images)
        {
            var result = _imagesData.Get(p => p.Id == images.Id);
            if (result!=null)
            {
                if (File.Exists(result.ImagePath))
                {
                    File.Delete(result.ImagePath);
                }
            }
            else
            {
                return new DataErrorResult<CarImages>("Error:belə bir şəkil yoxdur");
            }
          
            _imagesData.Delete(result);
            return new DataSuccessResult<CarImages>("Sekil silindi");
        }

        public IDataResult<CarImages> Update(CarImages images,string zroot)
        {
            var result = _imagesData.Get(p => p.Id == images.Id);
            if (result==null)
            {
                return new DataErrorResult<CarImages>("Yenilenmedi. Belə bir şəkil yoxdur");
            }
            File.Delete(result.ImagePath);
            webHelper.Add(images.files, zroot);
            result.Date = DateTime.Now.ToString("d");
            result.ImagePath = webHelper.rootPlusGuid;
            
            _imagesData.Update(result);
            return new DataSuccessResult<CarImages>("Ugurla yenilendi");
        }



        IDataResult<CarImages> CheckIfImagesCountisFive(int? carId)
        {
            var result = _imagesData.GetAll(p => p.CarId == carId);
            if (result.Count >= 5)
            {
                return new DataErrorResult<CarImages>("Bu masinin artiq 5 sekli var");

            }
            return new DataSuccessResult<CarImages>();
        }
    }
}
