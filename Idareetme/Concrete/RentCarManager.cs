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

namespace Idareetme.Concrete
{
    public class RentCarManager : IRentCarManager
    {
        ICarData _icarData;
       

      

        public RentCarManager(ICarData icarData)
        {
            _icarData = icarData;
        }

       
        public void Add(Car car)
        {
            if (car.ModelYear<2000)
            {
                Console.WriteLine("Avtomobil buraxilis ili 2000-den asagi ola bilmez");
                return;
            }
            _icarData.Add(car);
        }

        public void Delete(Car car)
        {
            _icarData.Delete(car);

        }
        public void Update(Car car)
        {
            _icarData.Update(car);

        }
        public Car Get(Car car)
        {
            return _icarData.Get(c => c.Id == car.Id);
        }

        public List<Car> GetAll()
        {
            return _icarData.GetAll();
        }

        public Car GetById(int id)
        {
            return _icarData.Get(c => c.Id == id);

        }
        public List<Car> GetCarsByBrandID(int brandId)
        {
            return _icarData.GetAll(p => p.BrandId == brandId);
        }
        public List<Car> GetCarsByColorID(int colorId)
        {
            return _icarData.GetAll(p => p.ColorId == colorId);
        }

        public List<DtoS> Joins()
        {
           return _icarData.Joins();
        }




    }
}
