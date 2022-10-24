using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    internal class ErrorrDataResult<T> : DataResult<T>
    {
        public ErrorrDataResult(T data) : base(data, false)
        {

        }
        public ErrorrDataResult(T data, string message) : base(data, false, message)
        {
        }
        public ErrorrDataResult() : base(default, false)
        {

        }
        public ErrorrDataResult(string message) : base(default, false, message)
        {
        }
    }
}
