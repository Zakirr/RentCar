using DataAcces.Abstract;
using Entities.Concrete;
using Melumatlar.Concrete.EfCarData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete.EfCarData
{
    public class EfCustomersData:EfDataRepositoryBase<Customers>,ICustomersData
    {
    }
}
