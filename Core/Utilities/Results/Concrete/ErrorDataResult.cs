using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }
        //Message vermek istemezsek;
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        // Data'yı default haliyle döndürmek istersek;
        public ErrorDataResult(string message) : base(default, false, message)
        {
            // default'un return tipi int'tir.

        }
        // Mesajsız default datayı döndürmek istersek:
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
