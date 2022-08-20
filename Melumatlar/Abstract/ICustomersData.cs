using Entities.Concrete;
using Melumatlar.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Abstract
{
    public interface ICustomersData:IDataRepository<Customers>
    {
    }
}
