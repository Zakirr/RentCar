using Business.Abstract;
using Girilenler.Concrete;
using Melumatlar.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentColorManager: IRentColorManager
    {

        IColorData _colorData;

        public RentColorManager(IColorData colorData)
        {
            _colorData = colorData;
        }

        public void Add(Color color)
        {
            _colorData.Add(color);
        }

        public void Delete(Color color)
        {
            _colorData.Delete(color);
        }

        public Color Get(Color color)
        {
            return _colorData.Get(p => p.ColorName==color.ColorName);
        }

        public List<Color> GetAll()
        {
            return _colorData.GetAll();
        }

        public Color GetById(int id)
        {
            return _colorData.Get(p => p.ColorId == id);
        }

        public void Update(Color color)
        {
            _colorData.Add(color);
        }

    }
}
