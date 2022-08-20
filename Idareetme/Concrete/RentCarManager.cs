using Girilenler.Concrete;
using Idareetme.Abstract;
using Melumatlar.Abstract;
using Girilenler.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Utilites.Concrete;
using Utilites.Abstract;
using System.Runtime.ConstrainedExecution;
using System.Drawing;

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

       
        public IDataResult<Car> Add(Car car)
        {
            //if (DateTime.Now.Month==a)
            //{
            //    return new DataErrorResult<Car>("Elave olunmadi");

            //}
            _icarData.Add(car);
            return new DataSuccessResult<Car>("Elave olundu");
        }

        public IDataResult<Car> Delete(Car car)
        {
            if (DateTime.Now.Month == a)
            {
                return new DataErrorResult<Car>("Silinmedi");

            }
            _icarData.Delete(car);
            return new DataSuccessResult<Car>("Silindi");

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
            if (DateTime.Now.Month==a)
            {
                return new DataErrorResult<Car>("Error");
            }
            
            return new DataSuccessResult<Car>( _icarData.Get(c => c.Id == car.Id),"Success");
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Month == a)
            {
                return new DataErrorResult<List<Car>>("A");
            }

            return new DataSuccessResult<List<Car>>(_icarData.GetAll());
        }

        public IDataResult<Car> GetById(int id)
        {
            if (DateTime.Now.Month == a)
            {
                return new DataErrorResult<Car>("Error getById");
            }

            return new DataSuccessResult<Car>(_icarData.Get(c => c.Id == id),"Success getById");

        }
        public IDataResult <List<Car>> GetCarsByBrandID(int brandId)
        {
            if (DateTime.Now.Month == a)
            {
                return new DataErrorResult<List<Car>>("Error getCarsByBrandId");
            }
            return new DataSuccessResult<List<Car>>(_icarData.GetAll(p => p.BrandId == brandId),"Success getCarsByBrandId");
        }
        public IDataResult<List<Car>> GetCarsByColorID(int colorId)
        {
            if (DateTime.Now.Month == a)
            {
                return new DataErrorResult<List<Car>>("Error GetCarsByColorID");
            }
            return new DataSuccessResult<List<Car>>(_icarData.GetAll(p => p.ColorId == colorId), "Success GetCarsByColorID");
        }

        public IDataResult<List<DtoS>>Joins()
        {
            return new DataSuccessResult<List<DtoS>>(_icarData.Joins(), "Success GetCarsByColorID");
        }




    }
}
