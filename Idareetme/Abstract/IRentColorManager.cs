using Girilenler.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentColorManager
    {
        public List<Color> GetAll();
        public Color Get(Color color);
        public Color GetById(int id);
        public void Add(Color color);
        public void Delete(Color color);
        public void Update(Color color);
    }
}
