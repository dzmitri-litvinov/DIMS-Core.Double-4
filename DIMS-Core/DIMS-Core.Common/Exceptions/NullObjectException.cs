using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIMS_Core.Common.Exceptions
{
    public class NullObjectException : BaseException
    {
        public string MethodName { get; }
        public NullObjectException(string methodName, string message) : base(message)
        {
            MethodName = methodName;
        }
    }
}
