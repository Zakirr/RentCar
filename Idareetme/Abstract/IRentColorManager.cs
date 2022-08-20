using Girilenler.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilites.Abstract;

namespace Business.Abstract
{
    public interface IRentColorManager
    {
        public IDataResult<List<Color>> GetAll();
        public IDataResult<Color> Get(Color color);
        public IDataResult<Color> GetById(int id);
        public IDataResult<Color> Add(Color color);
        public IDataResult<Color> Delete(Color color);
        public IDataResult<Color> Update(Color color);
    }
}
