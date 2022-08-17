using Girilenler.Concrete;
using Idareetme.Abstract;
using Melumatlar.Abstract;
using Girilenler.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idareetme.Concrete
{
    public class RentCarManager : IRentCarManager
    {
        ICarData _icarData;
        IColorData _icolorData;

        public RentCarManager(IColorData icolorData)
        {
            _icolorData = icolorData;
        }

        public RentCarManager(ICarData icarData)
        {
            _icarData = icarData;
        }

        public void Add(Car car)
        {
            _icarData.Add(car);
        }
        public void Add(Color color)
        {
            _icolorData.Add(color);
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
            return _icarData.Get(c=>c.Id==car.Id);
        }

        public List<Car> GetAll()
        {
            return _icarData.GetAll();
        }

        public Car GetById(int id)
        {
            return _icarData.Get(c=>c.Id==id);

        }
    }
}
