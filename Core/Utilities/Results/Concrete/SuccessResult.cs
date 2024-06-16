using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message):base(true,message)
        {
            // base'den kasıt Result class'ıdır.
        }
        public SuccessResult():base(true)
        {
            
        }
    }
}
