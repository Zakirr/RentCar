using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilites.Abstract;

namespace Business.Abstract
{
    public interface IRentalsManager
    {
        IDataResult<Rentals> Add(Rentals rentals);
        IDataResult<Rentals> Return(Rentals rentals);
    }
}
