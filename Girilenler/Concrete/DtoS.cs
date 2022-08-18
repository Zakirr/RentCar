using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class DtoS:IDtoS
    {

        public int Id { get; set; }
        public int BrandId { get; set; }
        public string ColorName { get; set; }
        public int ColorId { get; set; }
    }
}
