using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Abstract
{
    // DataResult hem mesaj hem de data içerir.
    // Message'ları tekrar yazmamak için IResult'tan inheritance alsın.
    public interface IDataResult<T> : IResult
    {
        // T generic tipini veririz çünkü her method farklı bir şey döndürüür örn: user,role vs.
        T Data { get; }
    }
}
