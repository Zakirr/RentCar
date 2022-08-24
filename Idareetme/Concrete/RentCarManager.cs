using Business.ValidationRules.FluentValidation;
using CoreAndUtilites.Aspects.Autofac.Validation;
using CoreAndUtilites.Utilities.Business;
using Entities.Concrete;
using Girilenler.Concrete;
using Idareetme.Abstract;
using Melumatlar.Abstract;
using Utilites.Abstract;
using Utilites.Concrete;

namespace Idareetme.Concrete
{
    public class RentCarManager : IRentCarManager
    {
        ICarData _icarData;
        int a = 9;




        public RentCarManager(ICarData icarData)
        {

            _icarData = icarData;

        }

        [ValidationAspect(typeof(CarValidator))]
        public IDataResult<Car> Add(Car car)
        {
            var result = BusinessRules<Car>.Run(CheckIfBrandCountIsTrue(car.BrandId), CheckIfNameLenghIsTrue(car.CarName));
            if (result != null)
            {
                return result;
            }

            _icarData.Add(car);
            return new DataSuccessResult<Car>("Elave olundu");
        }

        public IDataResult<Car> Delete(Car car)
        {
            if (DateTime.Now.Month != a)
            {
                _icarData.Delete(car);
                return new DataSuccessResult<Car>("Silindi");

            }
            return new DataErrorResult<Car>("Silinmedi");

        }
        public IDataResult<Car> Update(Car car)
        {
            if (DateTime.Now.Month == a)
            {
                return new DataErrorResult<Car>("Yenilenmedi");

            }
            _icarData.Update(car);
            return new DataSuccessResult<Car>("Yenilendi");

        }
        public IDataResult<Car> Get(Car car)
        {


            return new DataSuccessResult<Car>(_icarData.Get(c => c.Id == car.Id), "Success");
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Month == a)
            {
                return new DataErrorResult<List<Car>>("Error abi");
            }

            return new DataSuccessResult<List<Car>>(_icarData.GetAll(), "Success abi");
        }

        public IDataResult<Car> GetById(int id)
        {
            if (DateTime.Now.Month == a)
            {
                return new DataErrorResult<Car>("Error getById");
            }

            return new DataSuccessResult<Car>(_icarData.Get(c => c.Id == id), "Success getById");

        }
        public IDataResult<List<Car>> GetCarsByBrandID(int brandId)
        {
            if (DateTime.Now.Month == a)
            {
                return new DataErrorResult<List<Car>>("Error getCarsByBrandId");
            }
            return new DataSuccessResult<List<Car>>(_icarData.GetAll(p => p.BrandId == brandId), "Success getCarsByBrandId");
        }
        public IDataResult<List<Car>> GetCarsByColorID(int colorId)
        {
            if (DateTime.Now.Month == a)
            {
                return new DataErrorResult<List<Car>>("Error GetCarsByColorID");
            }
            return new DataSuccessResult<List<Car>>(_icarData.GetAll(p => p.ColorId == colorId), "Success GetCarsByColorID");
        }

        public IDataResult<List<DtoS>> Joins()
        {
            return new DataSuccessResult<List<DtoS>>(_icarData.Joins(), "Success GetCarsByColorID");
        }



        IDataResult<Car> CheckIfNameLenghIsTrue(string carName)
        {

            if (carName.Length < 3)
            {
                return new DataErrorResult<Car>("Error:Ad  3 hərfdən kiçik ola bilməz");
            }
            return new DataSuccessResult<Car>();

        }
        IDataResult<Car> CheckIfBrandCountIsTrue(int carBrandId)
        {
            var result = _icarData.GetAll(p => p.BrandId == carBrandId);
            if (result.Count >= 10)
            {
                return new DataErrorResult<Car>("Error:Brand limi keçildi");
            }
            return new DataSuccessResult<Car>();

        }


    }
}
