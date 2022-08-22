using Business.Abstract;
using Entities.Concrete;
using Girilenler.Concrete;
using Melumatlar.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilites.Abstract;
using Utilites.Concrete;

namespace Business.Concrete
{
    public class RentColorManager: IRentColorManager
    {

        IColorData _icolorData;
        int a = 9;




        public RentColorManager(IColorData icolorData)
        {
            _icolorData = icolorData;

        }


        public IDataResult<Color> Add(Color color)
        {
            if (DateTime.Now.Month == a)
            {
                return new DataErrorResult<Color>("Elave olunmadi");

            }
            _icolorData.Add(color);
            return new DataSuccessResult<Color>("Elave olundu");
        }

        public IDataResult<Color> Delete(Color color)
        {
            if (DateTime.Now.Month == a)
            {
                return new DataErrorResult<Color>("Silinmedi");

            }
            _icolorData.Delete(color);
            return new DataSuccessResult<Color>("Silindi");

        }
        public IDataResult<Color> Update(Color color)
        {
            if (DateTime.Now.Month == a)
            {
                return new DataErrorResult<Color>("Yenilenmedi");

            }
            _icolorData.Update(color);
            return new DataSuccessResult<Color>("Yenilendi");

        }
        public IDataResult<Color> Get(Color color)
        {
            if (DateTime.Now.Month == a)
            {
                return new DataErrorResult<Color>("Error");
            }

            return new DataSuccessResult<Color>(_icolorData.Get(c => c.ColorName == color.ColorName), "Success");
        }

        public IDataResult<List<Color>> GetAll()
        {
            if (DateTime.Now.Month == a)
            {
                return new DataErrorResult<List<Color>>("A");
            }

            return new DataSuccessResult<List<Color>>(_icolorData.GetAll());
        }

        public IDataResult<Color> GetById(int id)
        {
            var result = _icolorData.Get(c => c.ColorId == id);
            if (DateTime.Now.Month == a||result==null)
            {
                return new DataErrorResult<Color>("Error getById");
            }

            return new DataSuccessResult<Color>(result, "Success getById");

        }
     



    }
}
