using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIMS_Core.Common.Exceptions
{
    public class ZeroIdException : BaseException
    {
        public ZeroIdException(string paramName) : base(paramName)
        { }
    }
}
