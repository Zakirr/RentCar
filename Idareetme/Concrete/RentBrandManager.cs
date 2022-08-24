using Business.Abstract;
using Girilenler.Concrete;
using Melumatlar.Abstract;
using Utilites.Abstract;
using Utilites.Concrete;

namespace Business.Concrete
{
    public class RentBrandManager : IRentBrandManager
    {
        IBrandData _ibrandData;
        int a = 9;




        public RentBrandManager(IBrandData ibrandData)
        {
            _ibrandData = ibrandData;

        }


        public IDataResult<Brand> Add(Brand brand)
        {
            if (DateTime.Now.Month == a)
            {
                return new DataErrorResult<Brand>("Elave olunmadi");

            }
            _ibrandData.Add(brand);
            return new DataSuccessResult<Brand>("Elave olundu");
        }

        public IDataResult<Brand> Delete(Brand brand)
        {
            if (DateTime.Now.Month == a)
            {
                return new DataErrorResult<Brand>("Silinmedi");

            }
            _ibrandData.Delete(brand);
            return new DataSuccessResult<Brand>("Silindi");

        }
        public IDataResult<Brand> Update(Brand brand)
        {
            if (DateTime.Now.Month == a)
            {
                return new DataErrorResult<Brand>("Yenilenmedi");

            }
            _ibrandData.Update(brand);
            return new DataSuccessResult<Brand>("Yenilendi");

        }
        public IDataResult<Brand> Get(Brand brand)
        {
            if (DateTime.Now.Month == a)
            {
                return new DataErrorResult<Brand>("Error");
            }

            return new DataSuccessResult<Brand>(_ibrandData.Get(c => c.BrandName == brand.BrandName), "Success");
        }

        public IDataResult<List<Brand>> GetAll()
        {
            if (DateTime.Now.Month == a)
            {
                return new DataErrorResult<List<Brand>>("A");
            }

            return new DataSuccessResult<List<Brand>>(_ibrandData.GetAll());
        }

        public IDataResult<Brand> GetById(int id)
        {
            if (DateTime.Now.Month == a)
            {
                return new DataErrorResult<Brand>("Error getById");
            }

            return new DataSuccessResult<Brand>(_ibrandData.Get(c => c.BrandId == id), "Success getById");

        }
    }
}
