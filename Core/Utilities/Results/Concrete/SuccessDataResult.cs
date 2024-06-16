using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data,string message):base(data,true,message)
        {
            
        }
        //Message vermek istemezsek;
        public SuccessDataResult(T data):base(data,true)
        {
            
        }
        // Data'yı default haliyle döndürmek istersek;
        public SuccessDataResult(string message):base(default,true,message)
        {
            // default'un return tipi int'tir.
            
        }
        // Mesajsız default datayı döndürmek istersek:
        public SuccessDataResult():base(default,true)
        {
            
        }
    }
}
