using Girilenler.Concrete;
using Utilites.Abstract;

namespace Business.Abstract
{
    public interface IRentBrandManager
    {
        public IDataResult<List<Brand>> GetAll();
        public IDataResult<Brand> Get(Brand brand);
        public IDataResult<Brand> GetById(int id);
        public IDataResult<Brand> Add(Brand brand);
        public IDataResult<Brand> Delete(Brand brand);
        public IDataResult<Brand> Update(Brand brand);
    }
}
