using Girilenler.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idareetme.Abstract
{
    public interface IRentCarManager
    {
        public List<Car> GetAll();
        public Car Get(Car car);
        public Car GetById(int id);
        public void Add(Car car);
        public void Delete(Car car);
        public void Update(Car car);
        //public List<Car> GetById(int id);
        //public List<Car> Add(Car car);
        //public List<Car> Delete(Car car);
        //public List<Car> Update(Car car);

    }
}
