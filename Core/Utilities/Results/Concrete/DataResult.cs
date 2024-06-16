using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data,bool success, string message):base(success,message)
        {
            Data = data;
            // T türünde data, işlem sonucu ve mesaj döndürür
            // base'e yazdıklarımız result'taki kodlardır.
        }
        //Mesaj yazmak istemezsek aşağıdaki ctor çalışır
        public DataResult(T data,bool success):base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
