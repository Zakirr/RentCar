using Melumatlar.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilenler.Concrete
{
    public class Car:IEntity
    {
        public int BrandId { get; set; }
        public int Id { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public string Descripton { get; set; }
        public decimal DailyPrice { get; set; }
        public string CarName { get; set; }

    }
}
