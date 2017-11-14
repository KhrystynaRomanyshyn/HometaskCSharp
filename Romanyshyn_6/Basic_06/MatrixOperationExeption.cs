using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_06
{
   public class MatrixOperationExeption: ArgumentException 
    {
        public MatrixOperationExeption(string message) : base (message)
        { }
    }
}
