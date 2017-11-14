using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGroup
{
    class Fox : Predators
    {
        public new string Description()
        {
            return string.Format("This is fox");
        }
    }
}
