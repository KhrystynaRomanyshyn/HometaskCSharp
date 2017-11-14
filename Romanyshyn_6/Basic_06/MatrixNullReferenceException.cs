using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_06
{
    public class MatrixNullReferenceException : NullReferenceException
    {
        public MatrixNullReferenceException (string message) : base (message)
        { }
    }
}
