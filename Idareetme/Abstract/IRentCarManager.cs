using Girilenler.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilites.Abstract;
using Utilites.Concrete;

namespace Idareetme.Abstract
{
    public interface IRentCarManager
    {
        public IDataResult<List<Car>> GetAll();
        public IDataResult<Car> Get(Car car);
        public IDataResult<Car> GetById(int id);
        public IDataResult<Car> Add(Car car);
        public IDataResult<Car> Delete(Car car);
        public IDataResult<Car> Update(Car car);
        public IDataResult<List<Car>> GetCarsByBrandID(int brandId);

        public IDataResult<List<Car>> GetCarsByColorID(int colorId);
      
        //public List<Car> GetById(int id);
        //public List<Car> Add(Car car);
        //public List<Car> Delete(Car car);
        //public List<Car> Update(Car car);

    }
}
