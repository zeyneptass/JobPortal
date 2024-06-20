using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        // params ile istediğimiz kadar IResult implementasyonlu business method atabiliriz.
        public static IResult Run(params IResult[] logics)
        {
            // Aşağıdaki yapıda hatalı olan İş methodunu döndürür.
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;
                }
            }
            return null;
        }
    }
}
