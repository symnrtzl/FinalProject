using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    // mesaj ve işlem sonucu için IResult implemente edilir
    public interface IDataResult<T> :IResult
    {
        T Data { get; }
    }
}
