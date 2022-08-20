using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilites.Abstract;

namespace Utilites.Concrete
{
    public class DataSuccessResult<T> : DataResult<T>
    {
        public DataSuccessResult(T data,string message) : base(data,true, message)
        {
        }
        public DataSuccessResult(T data):base(data,true)
        {

        }
        public DataSuccessResult(string message) : base(default,true,message)
        {

        }
        public DataSuccessResult():base(true)
        {

        }

    }
}
