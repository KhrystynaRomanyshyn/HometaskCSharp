using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGroup
{
    public class Animal
    {
        public virtual string Description()
        {
            return string.Format("This is animal");
        }
    }
}
