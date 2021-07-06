using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIMS_Core.Common.Exceptions;

namespace DIMS_Core.DataAccessLayer.Extensions
{
    public static class RepositoryExtentions
    {
        public static void CheckIfZero(this int id)
        {
            if (id == 0)
            {
                throw new ZeroIdException("Invalid Id value 0");
            }
        }

        public static void CheckIfNullObject(this object obj, string methodName)
        {
            if (obj == null)
            {
                throw new NullObjectException(methodName, "Returned object from DB is null");
            }
        }
    }
}
