using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilites.Abstract;

namespace Utilites.Concrete
{
    public class DataErrorResult<T> : DataResult<T>
    {
        
        public DataErrorResult(T data, string message) : base(data, false, message)
        {

        }
        public DataErrorResult(T data) : base(data, false)
        {

        }
        public DataErrorResult():base(false)
        {

        }
        public DataErrorResult(string message):base(default,false,message)
        {

        }

    }
}
