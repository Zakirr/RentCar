using Girilenler.Concrete;
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
